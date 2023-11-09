using Restaurant.Core.Application.Dtos.SocialMedia;
using Restaurant.Core.Application.Dtos.Testimonial;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.TestimonialService
{
    public interface ITestimonialService :IGenericService<Testimonial , GenericTestimonialDto>
    {
        void TAdd(CreateTestimonialRequest createTestimonialRequest);
    }
}
