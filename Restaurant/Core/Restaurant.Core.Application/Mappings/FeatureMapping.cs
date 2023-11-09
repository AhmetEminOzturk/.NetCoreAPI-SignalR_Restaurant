using AutoMapper;
using Restaurant.Core.Application.Dtos.Feature.Requests;
using Restaurant.Core.Application.Dtos.Feature.Responses;
using Restaurant.Core.Application.Dtos.Feature;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Mappings
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, GenericFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureRequest>().ReverseMap();
            CreateMap<Feature, UpdateFeatureRequest>().ReverseMap();
            CreateMap<Feature, DisplayFeatureResponse>().ReverseMap();
            CreateMap<Feature, GetFeatureResponse>().ReverseMap();
        }
    }
}
