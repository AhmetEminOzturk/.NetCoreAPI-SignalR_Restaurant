using AutoMapper;
using Restaurant.Core.Application.Dtos.SocialMedia.Requests;
using Restaurant.Core.Application.Dtos.SocialMedia.Responses;
using Restaurant.Core.Application.Dtos.SocialMedia;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Mappings
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, GenericSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaRequest>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaRequest>().ReverseMap();
            CreateMap<SocialMedia, DisplaySocialMediaResponse>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaResponse>().ReverseMap();
        }
    }
}
