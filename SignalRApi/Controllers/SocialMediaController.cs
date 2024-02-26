﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                Title = createSocialMediaDto.Title,
                Icon = createSocialMediaDto.Icon,
                Url = createSocialMediaDto.Url,
            });

            return Ok("SocialMedia bilgisi ekelndi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("SocialMedia Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                Title = updateSocialMediaDto.Title,
                Icon = updateSocialMediaDto.Icon,
                Url = updateSocialMediaDto.Url,
                SocialMediaID = updateSocialMediaDto.SocialMediaID
            });

            return Ok("SocialMedia Güncellendi.");
        }
    }
}