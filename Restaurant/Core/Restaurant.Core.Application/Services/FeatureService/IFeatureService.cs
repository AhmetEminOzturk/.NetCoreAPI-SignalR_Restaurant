using Restaurant.Core.Application.Dtos.Feature;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.FeatureService
{
    public interface IFeatureService : IGenericService<Feature , GenericFeatureDto>
    {
    }
}
