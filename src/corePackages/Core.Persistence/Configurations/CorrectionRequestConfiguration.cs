using Core.Domain.Entities;
using Core.Persistence.Configurations.Base;
using Core.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.EntityConfigurations;

public class CorrectionRequestConfiguration : BaseConfiguration<CorrectionRequest, Guid>
{
    public override void Configure(EntityTypeBuilder<CorrectionRequest> builder)
    {
        base.Configure(builder);
        builder.ToTable("CorrectionRequests");


        ///Properties
        builder.Property(cr => cr.UserId).HasColumnName("UserId").IsRequired(true);
        builder.Property(cr => cr.RequestContent).HasColumnName("RequestContent").HasMaxLength(500).IsRequired(true);
        builder.Property(cr => cr.Status).IsRequired(true).HasColumnName("Status");

        //
        builder.HasOne<Article>(cr => cr.Article).WithMany(a => a.CorrectionRequest)
            .HasForeignKey(cr => cr.ArticleId);
        builder.HasOne<User>(cr => cr.User).WithMany(u => u.CorrectionRequests).HasForeignKey(cr => cr.UserId);

        builder.ToTable(TableNameConstants.CORRECTION_REQUEST);

    }
}