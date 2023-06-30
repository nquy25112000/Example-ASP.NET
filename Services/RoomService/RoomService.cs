using AutoMapper;
using Sample1.Data;
using Sample1.Dto;
using Sample1.Repository;
using Sample1.Services.HotelService;

namespace Sample1.Services.RoomService
{
    public class RoomService : IRoomService
    {
        private readonly RoomRepository _repository;
        private readonly IMapper _mapper;
        private readonly IHotelService _hotelService;
        public RoomService(RoomRepository repository, IMapper mapper, IHotelService hotelService) {
            _hotelService = hotelService;
            _repository = repository;
            _mapper = mapper;
        }
        public Room Create(RoomDto roomDto)
        {
            Room room = _mapper.Map<Room>(roomDto);
            _repository.Create(room);
            return room;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Room> findAllByHotelName(string name)
        {
            Hotel hotel = _hotelService.findByName(name);
            if (hotel == null) return new List<Room>();
            return this.findByHotelId(hotel.id);
        }

        public List<Room> findByHotelId(int id)
        {
            return _repository.findByHotelId(id);
        }

        public List<Room> GetAll()
        {
           return _repository.GetAll();
        }

        public Room GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Room Update(int id, RoomDto roomDto)
        {
            Room oldRoom = this.GetById(id);
            if (oldRoom == null) return null;
            _mapper.Map(roomDto, oldRoom);
            return _repository.Update(oldRoom);
        }
    }
}
