using Sample1.Data;
using Sample1.Dto;

namespace Sample1.Services.HotelService
{
    public interface IHotelService
    {
        List<Hotel> GetAll();
        Hotel GetById(int id);
        Hotel Create(HotelDto hotelDto);
        Hotel Update(int id, HotelDto hotelDto);
        void Delete(int id);
        Hotel findByName(string name);
    }
}
