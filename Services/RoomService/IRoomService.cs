using Sample1.Data;
using Sample1.Dto;

namespace Sample1.Services.RoomService
{
    public interface IRoomService
    {
        List<Room> GetAll();
        Room GetById(int id);
        Room Create(RoomDto roomDto);
        Room Update(int id, RoomDto roomDto);
        void Delete(int id);
        List<Room> findByHotelId(int id);
        List<Room> findAllByHotelName(string name);
    }
}
