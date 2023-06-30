
using Sample1.Data;
using Sample1.Dto;

namespace Sample1.Controllers
{
    public interface IHotelController
    {
        List<Hotel> GetAll();
        Hotel GetById(int id);
        Hotel Create(HotelDto hotel);
        Hotel Update(int id, HotelDto hotel);
        void Delete(int id);
    }
}
