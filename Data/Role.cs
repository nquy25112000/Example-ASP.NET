namespace Sample1.Data
{
    public class Role
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual List<User> users { get; set; } = new List<User>();
    }
}
