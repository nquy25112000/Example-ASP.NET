namespace Sample1.Data
{
    public class User
    {
        public int id { get; set; }
        public int roleId { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public virtual Role role { get; set; }
    }
}
