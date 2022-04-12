using News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace News.Configurations
{
    public class LikeInIdeaConfigurations : IEntityTypeConfiguration<LikeInIdea>
    {
        public void Configure(EntityTypeBuilder<LikeInIdea> builder)
        {

            builder.ToTable("LikeInIdea");
            builder.HasKey(t => new { t.likeInIdea_Id });

            builder.HasOne(t => t.AppUser).WithMany(ur => ur.likeInIdea)
     .HasForeignKey(pc => pc.likeInIdea_UserId);
            builder.HasOne(t => t.Idea).WithMany(ur => ur.likeInIdea)
     .HasForeignKey(pc => pc.likeInIdea_IdeaId);

        }
    }
}
