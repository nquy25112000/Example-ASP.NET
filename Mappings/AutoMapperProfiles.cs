using AutoMapper;
using Sample1.Data;
using Sample1.Dto;

namespace Sample1.Mappings
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Hotel, HotelDto>();
            CreateMap<HotelDto, Hotel>();

            CreateMap<Room, RoomDto>();
            CreateMap<RoomDto, Room>();
        }
    }
}
