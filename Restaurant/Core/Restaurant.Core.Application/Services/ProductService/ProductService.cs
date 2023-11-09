using AutoMapper;
using Restaurant.Core.Application.Dtos.Product.Requests;
using Restaurant.Core.Application.Dtos.Product;
using Restaurant.Core.Application.Services.ProductService;
using Restaurant.Core.Application.Services.ProductService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories;
using Restaurant.Infrastructure.Persistence.Repositories.ProductRepository;
using Restaurant.Infrastructure.Persistence.Repositories.ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.ProductService
{
    public class ProductService : GenericService<Product, GenericProductDto>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IGenericRepository<Product> repository, IMapper mapper, IProductRepository productRepository) : base(repository, mapper)
        {
            _productRepository = productRepository;
        }

        public void TAdd(CreateProductRequest createProductRequest)
        {
            var newEntity = _mapper.Map<Product>(createProductRequest);
            _productRepository.Add(newEntity);
         
        }
    }
}
