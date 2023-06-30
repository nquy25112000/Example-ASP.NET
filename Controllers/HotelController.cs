using Microsoft.AspNetCore.Mvc;
using Sample1.Data;
using Sample1.Dto;
using Sample1.Services.HotelService;

namespace Sample1.Controllers
{
    [Route("hotel")]
    [ApiController]
    public class HotelController : ControllerBase, IHotelController
    {

        private IHotelService _hotelService;


        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet("findAll", Name = "Find All Hotel")]
        public List<Hotel> GetAll()
        {
            List<Hotel> hotels = _hotelService.GetAll();

            return hotels;
        }

        [HttpGet("{id}", Name = "Get By Id")]
        public Hotel GetById(int id)
        {
            Hotel hotel = _hotelService.GetById(id);
            return hotel;
        }

        [HttpPost(Name = "Create")]
        public Hotel Create(HotelDto hoteldto)
        {
            Hotel hotel = _hotelService.Create(hoteldto);
            return hotel;
        }

        [HttpPut("{id}", Name = "Update")]
        public Hotel Update(int id, HotelDto hoteldto)
        {
            Hotel hotel = _hotelService.Update(id, hoteldto);
            return hotel;
        }

        [HttpDelete("{id}", Name = "Delete By Id")]
        public void Delete(int id)
        {
            _hotelService.Delete(id);
        }
    }
}
