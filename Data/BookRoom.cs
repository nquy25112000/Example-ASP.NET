using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample1.Data
{
    [Table("bookroom")]
    public class BookRoom
    {
        [Key]
        public int id { get; set; }
        public int roomId { get; set; }
        public int hotelId { get; set; }

        [ForeignKey("hotelId")]
        public Hotel hotel { get; set; }

        [ForeignKey("roomId")]
        public Room room { get; set; }
    }
}
