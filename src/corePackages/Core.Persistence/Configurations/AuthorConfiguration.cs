using Core.Domain.Entities;
using Core.Persistence.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.EntityConfigurations;

public class AuthorConfiguration : BaseConfiguration<Author,Guid>
{
    public override void Configure(EntityTypeBuilder<Author> builder)
    {
    base.Configure(builder);
    builder.ToTable("Authors");
    
        builder.Property(a => a.FirstName).IsRequired(true).HasColumnName("FirstName").HasMaxLength(250);
        
        builder.Property(a => a.LastName).IsRequired(true).HasColumnName("LastName").HasMaxLength(250);
        
        builder.Property(a => a.Email).IsRequired(true).HasColumnName("Email").HasMaxLength(250);
        
        builder.Property(a => a.CreatedBy).IsRequired(true).HasColumnName("CreatedBy").HasMaxLength(250);
        
        builder.Property(a => a.CreatedDate).IsRequired(true).HasColumnName("CreatedDate").HasMaxLength(250);
        
        builder.Property(a => a.ModifiedBy).IsRequired(true).HasColumnName("ModifiedBy").HasMaxLength(250);
        
        builder.Property(a => a.IsDeleted).IsRequired(true).HasColumnName("IsDeleted").HasMaxLength(250);
           
    }
}