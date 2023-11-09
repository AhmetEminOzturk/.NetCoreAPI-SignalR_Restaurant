using AutoMapper;
using Restaurant.Core.Application.Dtos.Discount.Requests;
using Restaurant.Core.Application.Dtos.Discount.Responses;
using Restaurant.Core.Application.Dtos.Discount;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Mappings
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, GenericDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountRequest>().ReverseMap();
            CreateMap<Discount, UpdateDiscountRequest>().ReverseMap();
            CreateMap<Discount, DisplayDiscountResponse>().ReverseMap();
            CreateMap<Discount, GetDiscountResponse>().ReverseMap();
        }
    }
}
