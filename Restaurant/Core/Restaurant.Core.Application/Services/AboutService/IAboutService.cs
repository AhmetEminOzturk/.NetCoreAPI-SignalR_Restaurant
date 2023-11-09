using Restaurant.Core.Application.Dtos.About;
using Restaurant.Core.Application.Dtos.About.Requests;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.AboutService
{
    public interface IAboutService : IGenericService<About , GenericAboutDto>
    {
        void TAdd(CreateAboutRequest createAboutRequest);
    }
}
