using Microsoft.EntityFrameworkCore;
using Sample1.Data;

namespace Sample1.Migrations.MigrationVersion
{
    public class AddTableRoleAndUser
    {
        public AddTableRoleAndUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(roleBuilder =>
            {
                roleBuilder.ToTable("Role");
                roleBuilder.HasKey(role => role.id);
                roleBuilder.Property(role => role.name).HasColumnName("name");
            });

            modelBuilder.Entity<User>(userBuilder =>
            {
                userBuilder.ToTable("User");
                userBuilder.HasKey(user => user.id);
                userBuilder.Property(user => user.name).HasColumnName("name");
                userBuilder.HasOne(user => user.role).WithMany(role => role.users)
                .HasForeignKey(user => user.roleId).HasConstraintName("user_role_fk");
            });
        }
    }
}
