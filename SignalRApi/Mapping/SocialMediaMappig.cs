using AutoMapper;
using SignalR.EntityLayer.Entities;
using SignalR.DtoLayer.SocialMediaDto;

namespace SignalRApi.Mapping
{
    public class SocialMediaMappig : Profile
    {
        public SocialMediaMappig()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
        }
    }
}