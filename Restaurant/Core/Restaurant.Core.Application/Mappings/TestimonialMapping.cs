using AutoMapper;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Application.Dtos.Testimonial.Responses;
using Restaurant.Core.Application.Dtos.Testimonial;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Mappings
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, GenericTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialRequest>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialRequest>().ReverseMap();
            CreateMap<Testimonial, DisplayTestimonialResponse>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialResponse>().ReverseMap();
        }
    }
}
