using AutoMapper;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services
{
    public class GenericService<Entity, Dto> : IGenericService<Entity, Dto> where Entity : BaseEntity where Dto : class
    {
        private readonly IGenericRepository<Entity> _repository;
        protected readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void TAdd(Dto dto)
        {
            Entity newEntity = _mapper.Map<Entity>(dto);
            _repository.Add(newEntity);
            var newDto = _mapper.Map<Dto>(newEntity);
        }

        public void TDelete(int id)
        {
            var entity = _repository.GetByID(id);
            _repository.Delete(entity);
        }

        public Dto TGetByID(int id)
        {
            var entity = _repository.GetByID(id);
            return _mapper.Map<Dto>(entity);
        }

        public List<Dto> TGetListAll()
        {
            var entities = _repository.GetListAll();
            return _mapper.Map<List<Dto>>(entities);
        }

        public void TUpdate(Dto dto)
        {
            var entity = _mapper.Map<Entity>(dto);
            _repository.Update(entity);
        }
    }
}
