using News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace News.Configurations
{
    public class UserInDepartmentConfigurations : IEntityTypeConfiguration<UserInDepartment>
    {
        public void Configure(EntityTypeBuilder<UserInDepartment> builder)
        {

            builder.ToTable("UserInDepartment");
            builder.HasKey(t => new { t.uid_UserId,t.uid_DepartmentId });

            builder.HasOne(t => t.AppUserFK).WithMany(ur => ur.userInDepartmentsList)
     .HasForeignKey(pc => pc.uid_UserId);
            builder.HasOne(t => t.DepartmentFK).WithMany(ur => ur.userInDepartmentsList)
     .HasForeignKey(pc => pc.uid_DepartmentId);


        }
    }
}
