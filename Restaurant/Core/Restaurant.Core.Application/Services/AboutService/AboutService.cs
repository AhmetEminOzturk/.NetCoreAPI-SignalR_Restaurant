using AutoMapper;
using Restaurant.Core.Application.Dtos.About.Requests;
using Restaurant.Core.Application.Dtos.About;
using Restaurant.Core.Application.Services.AboutService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories;
using Restaurant.Infrastructure.Persistence.Repositories.AboutRepository;
using Restaurant.Infrastructure.Persistence.Repositories.AboutRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.AboutService
{
    public class AboutService : GenericService<About, GenericAboutDto>, IAboutService
    {
        private readonly IAboutRepository _aboutRepository;
        public AboutService(IGenericRepository<About> repository, IMapper mapper, IAboutRepository aboutRepository) : base(repository, mapper)
        {
            _aboutRepository = aboutRepository;
        }

        public void TAdd(CreateAboutRequest createAboutRequest)
        {
            var newEntity = _mapper.Map<About>(createAboutRequest);
            _aboutRepository.Add(newEntity);          
        }
    }
}
