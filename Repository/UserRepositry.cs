using Microsoft.EntityFrameworkCore;
using Sample1.Data;
using Sample1.Dto;

namespace Sample1.Repository
{
    public class UserRepositry : BaseRepository<Users>
    {
        private readonly MyDbContext db;
        public UserRepositry(MyDbContext db) : base(db)
        {
            this.db = db;
        }

        public List<Users> getUserByRoleIds(List<int> roleIds)
        {
            List<Users> users = (from user in db.Users where roleIds.Contains(user.roleId)
                                 select new Users() { id = user.id, name = user.name}).ToList();
            return users;
        }

        public List<Users> findAllByRoleId(int roleId)
        {
            string query = $"SELECT * FROM Users where roleId = {roleId}";
            List<Users> result = db.Users.FromSqlRaw(query).ToList();
            return result;
        }

        public int findUserIdByName(string name)
        {
            Users user = (from u in db.Users where u.name == name select u).First();
            return user != null ? user.id : 0;
        }

        public (int, List<Users>) testMultipleReturn()
        {
            List<Users> users = new List<Users> {
                new Users { id = 1, name = "u1" },
                new Users { id = 2, name = "u2" },
                new Users { id = 3, name = "u3" }};

            return (users.Count, users);
        }

        public UserRole getByUserName(string name)
        {
            UserRole user = (from u in db.Users
                             join r in db.Roles on u.roleId equals r.id
                             where u.name == name
                             select new UserRole()
                             { id = u.id, name = u.name, roleName = r.name }).First();
            return user;
        }
    }
}
