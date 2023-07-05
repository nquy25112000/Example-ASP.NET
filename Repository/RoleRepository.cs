using Microsoft.EntityFrameworkCore;
using Sample1.Data;

namespace Sample1.Repository
{
    public class RoleRepository : BaseRepository<Roles>
    {
        private readonly MyDbContext _db;
        public RoleRepository(MyDbContext db) : base(db)
        {
            _db = db;
        }
        
        public new Roles GetById(int id)
        {
            List<int> ids = new List<int>() { 1, 2, 3, 4, 5 };
            return _db.Roles.Include(r => r.users).FirstOrDefault(r => ids.Contains(id));
        }
    }
}
