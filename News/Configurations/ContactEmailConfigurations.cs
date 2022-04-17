using News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace News.Configurations
{
    public class ContactEmailConfigurations : IEntityTypeConfiguration<ContactEmail>
    {
        public void Configure(EntityTypeBuilder<ContactEmail> builder)
        {

            builder.ToTable("ContactEmail");
            builder.HasKey(t => new { t.Id });


            

        }
    }
}
