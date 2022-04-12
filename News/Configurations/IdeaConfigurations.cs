using News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace News.Configurations
{
    public class IdeaConfigurations : IEntityTypeConfiguration<Idea>
    {
        public void Configure(EntityTypeBuilder<Idea> builder)
        {

            builder.ToTable("Idea");
            builder.HasKey(t => new { t.idea_Id });

            builder.HasOne(t => t.categoriesFK).WithMany(ur => ur.IdeaList)
     .HasForeignKey(pc => pc.idea_CategoryId);

            builder.HasOne(t => t.submissionFK).WithMany(ur => ur.IdeaList)
     .HasForeignKey(pc => pc.idea_SubmissionId);

            builder.HasOne(t => t.appUserFK).WithMany(ur => ur.ideasList)
     .HasForeignKey(pc => pc.idea_UserId).IsRequired(false);
            ;

        }
    }
}
