using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample1.Data
{
    [Table("room")]
    public class Room
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string price { get; set; }

        public int hotelId { get; set; }

        [ForeignKey("hotelId")]
        public virtual Hotel hotel { get; set; }
    }
}
 