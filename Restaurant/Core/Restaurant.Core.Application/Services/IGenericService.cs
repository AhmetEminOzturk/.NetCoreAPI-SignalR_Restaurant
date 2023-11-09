using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services
{
    public interface IGenericService <Entity, Dto> where Entity : BaseEntity where Dto : class
    {
        void TAdd(Dto dto);
        void TDelete(int id);
        void TUpdate(Dto dto);
        Dto TGetByID(int id);
        List<Dto> TGetListAll();
    }
}
