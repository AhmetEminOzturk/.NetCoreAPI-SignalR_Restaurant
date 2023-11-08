using Restaurant.Core.Application.Services.FeatureService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories.FeatureRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.FeatureService
{
    public class FeatureService : IFeatureService
    {
        private readonly IFeatureRepository _featureRepository;

        public FeatureService(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public void TAdd(Feature entity)
        {
            _featureRepository.Add(entity);
        }

        public void TDelete(Feature entity)
        {
            _featureRepository.Delete(entity);
        }

        public Feature TGetByID(int id)
        {
            return _featureRepository.GetByID(id);
        }

        public List<Feature> TGetListAll()
        {
            return _featureRepository.GetListAll();
        }

        public void TUpdate(Feature entity)
        {
            _featureRepository.Update(entity);
        }
    }
}
