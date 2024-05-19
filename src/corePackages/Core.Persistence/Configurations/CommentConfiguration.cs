using Core.Domain.Entities;
using Core.Persistence.Configurations.Base;
using Core.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.EntityConfigurations;

public class CommentConfiguration : BaseConfiguration<Comment,Guid>
{
    public override void Configure(EntityTypeBuilder<Comment> builder)
    {
    base.Configure(builder);
    builder.Property(c => c.Content).HasColumnName("CommentContents").IsRequired(true)
        .HasMaxLength(LengthContraints.TextContentLength);
    builder.Property(c => c.ArticleId).IsRequired(true).HasColumnName("ArticleID");
    builder.Property(c => c.UserId).IsRequired(true).HasColumnName("UserID");
    builder.Property(c => c.ApprovedUserId).IsRequired(true).HasColumnName("ApprovedUserId");
    builder.Property(c => c.IsPublished).IsRequired(true)
        .HasColumnName("IsPublished");
    builder.Property(c => c.IsApproved).IsRequired(true).HasColumnName("IsApproved");

    //
    builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comment).HasForeignKey(c => c.ArticleId);
    //builder.HasOne<User>(c => c.User).WithMany(u => u.Comments).HasForeignKey(c => c.UserId);
    //builder.HasOne<User>(c => c.User).WithMany(u => u.Comments).HasForeignKey(c => c.ApprovedUserId);   //?? Onay veren kiþinin Id bilgisi için!



    builder.ToTable(TableNameConstants.COMMENT);

    }
}