using Restaurant.Core.Application.Dtos.Product;
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
    }
}
