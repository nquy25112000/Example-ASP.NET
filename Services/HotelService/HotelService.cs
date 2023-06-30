using AutoMapper;
using Sample1.Data;
using Sample1.Dto;
using Sample1.Repository;

namespace Sample1.Services.HotelService
{

    public class HotelService : IHotelService
    {
        private readonly IMapper _mapper;

        private readonly HotelRepository _repository;

        public HotelService(IMapper mapper, HotelRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Hotel Create(HotelDto hotelDto)
        {
            Hotel hotel = _mapper.Map<Hotel>(hotelDto);
            _repository.Create(hotel);
            return hotel;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Hotel findByName(string name)
        {
            return _repository.findAllByName(name);
        }

        public List<Hotel> GetAll()
        {
            return _repository.GetAll();
        }

        public Hotel GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Hotel Update(int id, HotelDto hotelDto)
        {
            Hotel oldHotel = this.GetById(id);
            if (oldHotel == null) return null;
            _mapper.Map(hotelDto, oldHotel);
            return _repository.Update(oldHotel);
        }
    }
}
