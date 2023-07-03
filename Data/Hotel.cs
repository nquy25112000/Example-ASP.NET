using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample1.Data
{
    [Table("hotel")]
    public class Hotel
    {
        [Key]
        public int id {  get; set; }

        [Required]
        public string name { get; set; }

        public virtual List<Room> rooms { get; set; } = new List<Room>();
    }
}
