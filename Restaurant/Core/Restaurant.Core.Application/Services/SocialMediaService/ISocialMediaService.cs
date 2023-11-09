using Restaurant.Core.Application.Dtos.SocialMedia;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.SocialMediaService
{
    public interface ISocialMediaService : IGenericService<SocialMedia , GenericSocialMediaDto>
    {
    }
}
