using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.ProductRepository
{
    public interface IProductRepository :IGenericRepository<Product>
    {
        List<Product> GetProductsWithCategories();
    }
}
