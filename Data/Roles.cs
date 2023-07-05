namespace Sample1.Data
{
    public class Roles
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual List<Users> users { get; set; } = new List<Users>();
    }
}
