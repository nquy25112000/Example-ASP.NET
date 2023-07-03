using Sample1.Data;
using Sample1.Dto;

namespace Sample1.Services.RoleService
{
    public interface IRoleService
    {
        List<Role> GetAll();
        Role GetById(int id);
        Role Create(RoleDto hotelDto);
        Role Update(int id, RoleDto hotelDto);
        void Delete(int id);
        Role findByName(string name);
    }
}
