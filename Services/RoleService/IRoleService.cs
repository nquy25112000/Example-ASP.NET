using Sample1.Data;
using Sample1.Dto;

namespace Sample1.Services.RoleService
{
    public interface IRoleService
    {
        List<Roles> GetAll();
        Roles GetById(int id);
        Roles Create(RoleDto hotelDto);
        Roles Update(int id, RoleDto hotelDto);
        void Delete(int id);
        Roles findByName(string name);
    }
}
