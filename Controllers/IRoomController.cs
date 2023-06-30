﻿using Sample1.Data;
using Sample1.Dto;

namespace Sample1.Controllers
{
    public interface IRoomController
    {
        List<Room> GetAll();
        Room GetById(int id);
        Room Create(RoomDto roomDto);
        Room Update(int id, RoomDto roomDto);
        void Delete(int id);
        List<Room> findAllByHotelId(int hotelId);
        List<Room> findAllByHotelName(string name);
    }
}
