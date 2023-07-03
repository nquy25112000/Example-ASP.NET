using AutoMapper;
using Sample1.Data;
using Sample1.Dto;
using Sample1.Repository;

namespace Sample1.Services.RoleService
{
    public class RoleService : IRoleService
    {
        private readonly IMapper mapper;

        private readonly RoleRepository repository;
        public RoleService(IMapper mapper, RoleRepository repository)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Role Create(RoleDto hotelDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Role findByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public Role GetById(int id)
        {
            return repository.GetById(id);
        }

        public Role Update(int id, RoleDto hotelDto)
        {
            throw new NotImplementedException();
        }
    }
}
