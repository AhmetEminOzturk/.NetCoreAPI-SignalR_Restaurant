using AutoMapper;
using Restaurant.Core.Application.Dtos.Testimonial;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Application.Services.TestimonialService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories;
using Restaurant.Infrastructure.Persistence.Repositories.TestimonialRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.TestimonialService
{
    public class TestimonialService : GenericService<Testimonial, GenericTestimonialDto>, ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;
        public TestimonialService(IGenericRepository<Testimonial> repository, IMapper mapper, ITestimonialRepository testimonialRepository) : base(repository, mapper)
        {
            _testimonialRepository = testimonialRepository;
        }

        public void TAdd(CreateTestimonialRequest createTestimonialRequest)
        {
            var newEntity = _mapper.Map<Testimonial>(createTestimonialRequest);
            _testimonialRepository.Add(newEntity);
            
        }
    }
}
