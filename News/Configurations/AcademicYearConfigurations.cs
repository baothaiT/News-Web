using News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace News.Configurations
{
    public class AcademicYearConfigurations : IEntityTypeConfiguration<AcademicYear>
    {
        public void Configure(EntityTypeBuilder<AcademicYear> builder)
        {

            builder.ToTable("AcademicYear");
            builder.HasKey(t => new { t.academicYear_Id });



        }
    }
}
