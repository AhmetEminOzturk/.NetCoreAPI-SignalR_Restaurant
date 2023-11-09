using Restaurant.Core.Application.Dtos.Discount;
using Restaurant.Core.Application.Dtos.Discount.Requests;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.DiscountService
{
    public interface IDiscountService : IGenericService<Discount , GenericDiscountDto>
    {
        void TAdd(CreateDiscountRequest createDiscountRequest);
    }
}
