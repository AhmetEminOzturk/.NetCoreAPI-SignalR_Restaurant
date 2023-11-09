using AutoMapper;
using Restaurant.Core.Application.Dtos.Booking.Requests;
using Restaurant.Core.Application.Dtos.Booking.Responses;
using Restaurant.Core.Application.Dtos.Booking;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Mappings
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, GenericBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingRequest>().ReverseMap();
            CreateMap<Booking, UpdateBookingRequest>().ReverseMap();
            CreateMap<Booking, DisplayBookingResponse>().ReverseMap();
            CreateMap<Booking, GetBookingResponse>().ReverseMap();
        }
    }
}
