using Core.Domain.Entities;
using Core.Persistence.Configurations.Base;
using Core.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.EntityConfigurations;

public class TagConfiguration : BaseConfiguration<Tag,Guid>
{
    public override void Configure(EntityTypeBuilder<Tag> builder)
    {
    base.Configure(builder);
    builder.ToTable(TableNameConstants.TAGS);
    
        builder.Property(t => t.Name).IsRequired(true).HasColumnName("Name").HasMaxLength(50);
            //builder.Property(t => t.ArticleTags).IsRequired(true).HasColumnName(ColumNameConstants.ARTICLE_TAGS);


           
    }
}