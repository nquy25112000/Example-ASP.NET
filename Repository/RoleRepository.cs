using Microsoft.EntityFrameworkCore;
using Sample1.Data;

namespace Sample1.Repository
{
    public class RoleRepository : BaseRepository<Role>
    {
        private readonly MyDbContext _db;
        public RoleRepository(MyDbContext db) : base(db)
        {
            _db = db;
        }
        
        public new Role GetById(int id)
        {
            return _db.Roles.Include(r => r.users).FirstOrDefault(r => r.id == id);
        }
    }
}
