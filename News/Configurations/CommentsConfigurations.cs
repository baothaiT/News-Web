using News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace News.Configurations
{
    public class CommentsConfigurations : IEntityTypeConfiguration<Comments>
    {
        public void Configure(EntityTypeBuilder<Comments> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(t => new { t.cmt_Id });

            builder.HasOne(t => t.AppUserFk).WithMany(ur => ur.Comments)
     .HasForeignKey(pc => pc.cmt_UserId);

            builder.HasOne(t => t.IdeaFk).WithMany(ur => ur.Comments)
     .HasForeignKey(pc => pc.cmt_IdeaId).IsRequired(false);
        }
    }
}
