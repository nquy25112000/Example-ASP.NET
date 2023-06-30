using Microsoft.AspNetCore.Mvc;
using Sample1.Data;
using Sample1.Dto;
using Sample1.Services.HotelService;
using Sample1.Services.RoomService;

namespace Sample1.Controllers
{
    [Route("room")]
    [ApiController]
    public class RoomController : IRoomController
    {
        private readonly IRoomService service;

        public RoomController(IRoomService service) {
            this.service = service;
        }

        [HttpPost]
        public Room Create([FromBody] RoomDto roomDto)
        {
            return service.Create(roomDto);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }

        [HttpGet("findbyhotel/{hotelId}")]
        public List<Room> findAllByHotelId(int hotelId)
        {
            return service.findByHotelId(hotelId);
        }

        [HttpGet("findbyhotelname")]
        public List<Room> findAllByHotelName([FromQuery] string name)
        {
            return service.findAllByHotelName(name);
        }

        [HttpGet("findAll")]
        public List<Room> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("{id}")]
        public Room GetById(int id)
        {
            return service.GetById(id);
        }

        [HttpPut("{id}")]
        public Room Update(int id, RoomDto roomDto)
        {
            return service.Update(id, roomDto);
        }
    }
}
