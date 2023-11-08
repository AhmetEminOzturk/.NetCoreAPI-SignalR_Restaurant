using Restaurant.Core.Application.Services.ProductService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories.ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void TAdd(Product entity)
        {
            _productRepository.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public Product TGetByID(int id)
        {
            return _productRepository.GetByID(id);
        }

        public List<Product> TGetListAll()
        {
            return _productRepository.GetListAll();
        }

        public void TUpdate(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}
