using Restaurant.Core.Application.Dtos.Product;
using Restaurant.Core.Application.Dtos.Product.Requests;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.ProductService
{
    public interface IProductService : IGenericService<Product , GenericProductDto>
    {
        void TAdd(CreateProductRequest createProductRequest);
    }
}
