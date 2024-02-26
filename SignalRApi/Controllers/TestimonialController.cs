using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestoimonialService _testoimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestoimonialService testoimonialService, IMapper mapper)
        {
            _testoimonialService = testoimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testoimonialService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testoimonialService.TAdd(new Testimonial()
            {
                ImageUrl = createTestimonialDto.ImageUrl,
                Comment = createTestimonialDto.Comment,
                Name = createTestimonialDto.Name,
                Status = createTestimonialDto.Status,
                Title = createTestimonialDto.Title,
            });

            return Ok("Testimonial bilgisi ekelndi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testoimonialService.TGetByID(id);
            _testoimonialService.TDelete(value);
            return Ok("Testimonial Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testoimonialService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testoimonialService.TUpdate(new Testimonial()
            {
                ImageUrl = updateTestimonialDto.ImageUrl,
                Comment = updateTestimonialDto.Comment,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status,
                Title = updateTestimonialDto.Title,
            });

            return Ok("Testimonial Güncellendi.");
        }
    }
}