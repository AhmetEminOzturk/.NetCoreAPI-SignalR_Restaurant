using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories.AboutRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.AboutService
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutService(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public void TAdd(About entity)
        {
            _aboutRepository.Add(entity);
        }

        public void TDelete(About entity)
        {
            _aboutRepository.Delete(entity);
        }

        public About TGetByID(int id)
        {
            return _aboutRepository.GetByID(id);
        }

        public List<About> TGetListAll()
        {
            return _aboutRepository.GetListAll();
        }

        public void TUpdate(About entity)
        {
            _aboutRepository.Update(entity);
        }
    }
}
