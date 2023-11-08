using Restaurant.Core.Application.Services.SocialMediaService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories.SocialMediaRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.SocialMediaService
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly ISocialMediaRepository _socialMediaRepository;

        public SocialMediaService(ISocialMediaRepository socialMediaRepository)
        {
            _socialMediaRepository = socialMediaRepository;
        }

        public void TAdd(SocialMedia entity)
        {
            _socialMediaRepository.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMediaRepository.Delete(entity);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaRepository.GetByID(id);
        }

        public List<SocialMedia> TGetListAll()
        {
            return _socialMediaRepository.GetListAll();
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaRepository.Update(entity);
        }
    }
}
