using News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace News.Configurations
{
    public class SubmissionConfigurations : IEntityTypeConfiguration<Submission>
    {
        public void Configure(EntityTypeBuilder<Submission> builder)
        {

            builder.ToTable("Submission");
            builder.HasKey(t => new { t.submission_Id });


            builder.HasOne(t => t.userFK).WithMany(ur => ur.Submission)
    .HasForeignKey(pc => pc.submission_UserId).IsRequired(false);
        }
    }
}
