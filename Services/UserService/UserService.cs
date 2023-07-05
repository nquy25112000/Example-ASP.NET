using Sample1.Data;
using Sample1.Dto;
using Sample1.Repository;

namespace Sample1.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly UserRepositry repositry;
        public UserService(UserRepositry repositry) 
        {
            this.repositry = repositry;
        }

        public List<Users> GetAll()
        {
            return repositry.GetAll();
        }

        public UserRole GetUserAndRole(string name)
        {
            return repositry.getByUserName(name);
        }
    }
}
