using AutoMapper;
using Restaurant.Core.Application.Dtos.Feature.Requests;
using Restaurant.Core.Application.Dtos.Feature;
using Restaurant.Core.Application.Services.FeatureService;
using Restaurant.Core.Application.Services.FeatureService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories;
using Restaurant.Infrastructure.Persistence.Repositories.FeatureRepository;
using Restaurant.Infrastructure.Persistence.Repositories.FeatureRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.FeatureService
{
    public class FeatureService : GenericService<Feature, GenericFeatureDto>, IFeatureService
    {
        private readonly IFeatureRepository _featureRepository;
        public FeatureService(IGenericRepository<Feature> repository, IMapper mapper, IFeatureRepository featureRepository) : base(repository, mapper)
        {
            _featureRepository = featureRepository;
        }

        public void TAdd(CreateFeatureRequest createFeatureRequest)
        {
            var newEntity = _mapper.Map<Feature>(createFeatureRequest);
            _featureRepository.Add(newEntity);
            
        }
    }
}
