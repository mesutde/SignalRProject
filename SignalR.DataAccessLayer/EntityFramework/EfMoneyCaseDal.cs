using SignalR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(SignalRContext context) : base(context)
        {
        }

        public void Add(MoneyCase entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MoneyCase entity)
        {
            throw new NotImplementedException();
        }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new SignalRContext();

            var deneme = context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();

            return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }

        public void Update(MoneyCase entity)
        {
            throw new NotImplementedException();
        }

        MoneyCase IGenericDal<MoneyCase>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<MoneyCase> IGenericDal<MoneyCase>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}