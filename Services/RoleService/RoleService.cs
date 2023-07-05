using AutoMapper;
using Newtonsoft.Json.Linq;
using Sample1.Data;
using Sample1.Dto;
using Sample1.Repository;
using Sample1.Services.UserService;
using System.Collections.Concurrent;

namespace Sample1.Services.RoleService
{
    public class RoleService : IRoleService
    {
        private readonly IMapper mapper;

        private readonly RoleRepository repository;

        private readonly IUserService userService;
        public RoleService(IMapper mapper, RoleRepository repository, IUserService userService)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.userService = userService;
        }

        public Roles Create(RoleDto hotelDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Roles findByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Roles> GetAll()
        {
            List<Roles> roles = repository.GetAll();
            List<Users> users = userService.GetAll();
            ConcurrentDictionary<int, List<Users>> mapUser = new ConcurrentDictionary<int, List<Users>>();
            users.ForEach(user =>
            {
                mapUser.AddOrUpdate(user.roleId, new List<Users> { user }, (key, list) =>
                {
                    list.Add(user);
                    return list;
                });
            });
            roles.ForEach(role =>
            {
                if (mapUser.TryGetValue(role.id, out List<Users> userList))
                {
                    role.users = userList;
                }
            });
            return roles;
            
        }

        public Roles GetById(int id)
        {
            return repository.GetById(id);
        }

        public Roles Update(int id, RoleDto hotelDto)
        {
            throw new NotImplementedException();
        }
    }
}
