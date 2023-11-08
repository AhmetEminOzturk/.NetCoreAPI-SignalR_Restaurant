using Restaurant.Core.Application.Services.TestimonialService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories.TestimonialRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.TestimonialService
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialRepository.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialRepository.Delete(entity);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialRepository.GetByID(id);
        }

        public List<Testimonial> TGetListAll()
        {
            return _testimonialRepository.GetListAll();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialRepository.Update(entity);
        }
    }
}
