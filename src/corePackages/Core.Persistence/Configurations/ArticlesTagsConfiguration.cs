using Core.Domain.Entities;
using Core.Persistence.Configurations.Base;
using Core.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Persistence.Configurations
{
    public class ArticlesTagsConfiguration : BaseConfiguration<ArticlesTags, Guid>
    {
        public override void Configure(EntityTypeBuilder<ArticlesTags> builder)
        {
            builder.ToTable(TableNameConstants.ARTICLESTAGS);

            builder.HasKey(at => new { at.ArticleId, at.TagId });
            // Article ile olan ilişki
            builder.HasOne(at => at.Article)
                .WithMany(a => a.ArticleTags)
                .HasForeignKey(at => at.ArticleId);

            // Tag ile olan ilişki
            builder.HasOne(at => at.Tag)
                .WithMany(t => t.ArticleTags)
                .HasForeignKey(at => at.TagId);
        }
    }
}
