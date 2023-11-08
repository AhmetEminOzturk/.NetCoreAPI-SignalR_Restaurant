using Restaurant.Core.Application.Services.DiscountService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories.DiscountRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.DiscountService
{
    public class DiscountService: IDiscountService
    {
        private readonly IDiscountRepository _discountRepository;

        public DiscountService(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public void TAdd(Discount entity)
        {
            _discountRepository.Add(entity);
        }

        public void TDelete(Discount entity)
        {
            _discountRepository.Delete(entity);
        }

        public Discount TGetByID(int id)
        {
            return _discountRepository.GetByID(id);
        }

        public List<Discount> TGetListAll()
        {
            return _discountRepository.GetListAll();
        }

        public void TUpdate(Discount entity)
        {
            _discountRepository.Update(entity);
        }
    }
}
