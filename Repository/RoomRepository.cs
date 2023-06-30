using Sample1.Data;

namespace Sample1.Repository
{
    public class RoomRepository : BaseRepository<Room>
    {
        private readonly MyDbContext _db;
        public RoomRepository(MyDbContext db) : base(db)
        {
            _db = db;
        }

        public List<Room> findByHotelId(int hotelId)
        {
            List<Room> rooms = _db.Set<Room>().Where(room => room.hotelId == hotelId).ToList();
            return rooms;
        }
    }
}
