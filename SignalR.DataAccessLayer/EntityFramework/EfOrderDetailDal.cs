using SignalR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfOrderDetailDal : GenericRepository<OrderDetail>, IOrderDetailDal
    {
        public EfOrderDetailDal(SignalRContext context) : base(context)
        {
        }

        public void Add(IOrderDetailDal entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IOrderDetailDal entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IOrderDetailDal entity)
        {
            throw new NotImplementedException();
        }

        IOrderDetailDal IGenericDal<IOrderDetailDal>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<IOrderDetailDal> IGenericDal<IOrderDetailDal>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}