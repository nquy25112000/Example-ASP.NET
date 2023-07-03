using Microsoft.EntityFrameworkCore;
using Sample1.Migrations.MigrationVersion;
using System.Data;

namespace Sample1.Data
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}

        #region DbSet
        public DbSet<Hotel> HotelSet { get; set; }
        public DbSet<Room> RoomSet { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        //public object Configuration { get; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddTableRoleAndUser addTableRoleAndUser = new AddTableRoleAndUser(modelBuilder);
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }*/
    }
}
