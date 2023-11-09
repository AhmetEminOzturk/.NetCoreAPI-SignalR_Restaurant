using AutoMapper;
using Restaurant.Core.Application.Dtos.SocialMedia.Requests;
using Restaurant.Core.Application.Dtos.SocialMedia;
using Restaurant.Core.Application.Services.SocialMediaService;
using Restaurant.Core.Application.Services.SocialMediaService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories;
using Restaurant.Infrastructure.Persistence.Repositories.SocialMediaRepository;
using Restaurant.Infrastructure.Persistence.Repositories.SocialMediaRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.SocialMediaService
{
    public class SocialMediaService : GenericService<SocialMedia, GenericSocialMediaDto>, ISocialMediaService
    {
        private readonly ISocialMediaRepository _socialMediaRepository;
        public SocialMediaService(IGenericRepository<SocialMedia> repository, IMapper mapper, ISocialMediaRepository socialMediaRepository) : base(repository, mapper)
        {
            _socialMediaRepository = socialMediaRepository;
        }

        public void TAdd(CreateSocialMediaRequest createSocialMediaRequest)
        {
            var newEntity = _mapper.Map<SocialMedia>(createSocialMediaRequest);
            _socialMediaRepository.Add(newEntity);
            
        }
    }
}
