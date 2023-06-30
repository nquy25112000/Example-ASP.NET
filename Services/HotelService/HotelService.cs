using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample1.Data;
using Sample1.Dto;
using System.Xml.Linq;

namespace Sample1.Services.HotelService
{

    public class HotelService : IHotelService
    {
        private readonly MyDbContext _db;

        private readonly IMapper _mapper;
        public HotelService(MyDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        public List<Hotel> GetAll()
        {
            return _db.HotelSet.ToList();
        }

        public Hotel GetById(int id)
        {
            return _db.HotelSet.SingleOrDefault(h => h.id == id);
        }

        public Hotel Create(HotelDto hotelDto)
        {
            Hotel hotel = _mapper.Map<Hotel>(hotelDto);
            _db.HotelSet.Add(hotel);
            _db.SaveChanges();
            return hotel;
        }


        public Hotel Update(int id, HotelDto hotelDto)
        {
            Hotel oldHotel = _db.HotelSet.SingleOrDefault(h => h.id == id);
            if (oldHotel == null) return null;
            _mapper.Map(hotelDto, oldHotel);
            _db.SaveChanges();
            return oldHotel;

        }

        public void Delete(int id)
        {
            var oldHotel = _db.HotelSet.SingleOrDefault(h => h.id == id);
            if (oldHotel == null) return;
            _db.HotelSet.Remove(oldHotel);
            _db.SaveChanges();
        }
    }
}
