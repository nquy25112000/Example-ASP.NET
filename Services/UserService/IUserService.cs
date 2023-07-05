using Sample1.Data;
using Sample1.Dto;

namespace Sample1.Services.UserService
{
    public interface IUserService
    {
        List<Users> GetAll();
        UserRole GetUserAndRole(string name);
    }
}
