using AutoMapper;
using Restaurant.Core.Application.Dtos.About;
using Restaurant.Core.Application.Dtos.About.Requests;
using Restaurant.Core.Application.Dtos.About.Responses;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Mappings
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About,GenericAboutDto>().ReverseMap();
            CreateMap<About,CreateAboutRequest>().ReverseMap();
            CreateMap<About,UpdateAboutRequest>().ReverseMap();
            CreateMap<About,DisplayAboutResponse>().ReverseMap();
            CreateMap<About,GetAboutResponse>().ReverseMap();
        }
    }
}
