using AutoMapper;
using Restaurant.Core.Application.Dtos.Discount.Requests;
using Restaurant.Core.Application.Dtos.Discount;
using Restaurant.Core.Application.Services.DiscountService;
using Restaurant.Core.Application.Services.DiscountService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories;
using Restaurant.Infrastructure.Persistence.Repositories.DiscountRepository;
using Restaurant.Infrastructure.Persistence.Repositories.DiscountRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.DiscountService
{
    public class DiscountService : GenericService<Discount, GenericDiscountDto>, IDiscountService
    {
        private readonly IDiscountRepository _discountRepository;
        public DiscountService(IGenericRepository<Discount> repository, IMapper mapper, IDiscountRepository discountRepository) : base(repository, mapper)
        {
            _discountRepository = discountRepository;
        }

        public void TAdd(CreateDiscountRequest createDiscountRequest)
        {
            var newEntity = _mapper.Map<Discount>(createDiscountRequest);
            _discountRepository.Add(newEntity);
            
        }
    }
}
