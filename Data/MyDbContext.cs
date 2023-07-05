using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Sample1.Data
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}

        #region DbSet
        public DbSet<Hotel> HotelSet { get; set; }
        public DbSet<Room> RoomSet { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }

        //public object Configuration { get; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>(roleBuilder =>
            {
                roleBuilder.ToTable("Roles");
                roleBuilder.HasKey(role => role.id);
                roleBuilder.Property(role => role.name).HasColumnName("name");
            });

            modelBuilder.Entity<Users>(userBuilder =>
            {
                userBuilder.ToTable("Users");
                userBuilder.HasKey(user => user.id);
                userBuilder.Property(user => user.name).HasColumnName("name");
                userBuilder.HasOne(user => user.role).WithMany(role => role.users)
                .HasForeignKey(user => user.roleId).HasConstraintName("user_role_fk");
            });
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }*/
    }
}
