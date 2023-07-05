using Microsoft.EntityFrameworkCore;
using Sample1.Data;

namespace Sample1.Repository
{
    public class HotelRepository : BaseRepository<Hotel>
    {
        private readonly MyDbContext _db;
        public HotelRepository(MyDbContext db) : base(db)
        {
            _db = db;
        }

        public Hotel findAllByName(string name)
        {
            return _db.Set<Hotel>().Where(hotel => hotel.name == name).First();
        }
    }
}
