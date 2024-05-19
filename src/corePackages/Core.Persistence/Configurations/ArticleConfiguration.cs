using Core.Domain.Entities;
using Core.Persistence.Configurations.Base;
using Core.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.EntityConfigurations;

public class ArticleConfiguration : BaseConfiguration<Article, Guid>
{
    public override void Configure(EntityTypeBuilder<Article> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.Title).HasColumnName("Title").IsRequired(true).HasMaxLength(LengthContraints.CreatedByMaxLength);
        builder.Property(x => x.Content).HasColumnName("Content").IsRequired(true);
        builder.Property(x => x.Thumbnail).HasColumnName("Thumbnail").HasMaxLength(LengthContraints.DescriptionMaxLength);
        builder.Property(a => a.Date).IsRequired(true).HasColumnName("Date").HasMaxLength(250);

        builder.Property(a => a.ViewCount).IsRequired(true).HasColumnName("ViewCount").HasMaxLength(250);

        builder.Property(a => a.CommentCount).IsRequired(true).HasColumnName("CommentCount").HasMaxLength(250);

        builder.Property(a => a.CategoryId).IsRequired(true).HasColumnName("CategoryId").HasMaxLength(250);



        //Ýliþkiler
        builder.HasOne(x => x.Category).WithMany(x => x.Articles).HasForeignKey(x => x.CategoryId);
        builder.ToTable(TableNameConstants.ARTICLE);
        builder.HasData(data: GetSeeds());
    }


    private static HashSet<Article> GetSeeds()
    {
        HashSet<Article> articles =
        [
            new Article { Id = Guid.NewGuid(), Title = "C# 9.0", Content = "C# 9.0 ile ilgili makaleler", Thumbnail = "csharp.png", Date = DateTime.Now, ViewCount = 100, CommentCount = 10, CategoryId = Guid.Parse("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), CreatedBy = "System", CreatedDate = DateTime.Now,IsApproved = true},

            new Article { Id = Guid.NewGuid(), Title = "Java 11", Content = "Java 11 ile ilgili makaleler", Thumbnail = "java.png", Date = DateTime.Now, ViewCount = 100, CommentCount = 10, CategoryId = Guid.Parse("c33260dd-b051-4a2d-923a-4c16553e4753"), CreatedBy = "System", CreatedDate = DateTime.Now,IsApproved = true},

            new Article { Id = Guid.NewGuid(), Title = "Python 3.9", Content = "Python 3.9 ile ilgili makaleler", Thumbnail = "python.png", Date = DateTime.Now, ViewCount = 100, CommentCount = 10, CategoryId = Guid.Parse("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), CreatedBy = "System", CreatedDate = DateTime.Now,IsApproved = false},
        ];

        return articles;
    }
}