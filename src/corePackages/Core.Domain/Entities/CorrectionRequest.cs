using Core.Domain.ComplexTypes.Enums;
using Core.Domain.Entities.Base;

namespace Core.Domain.Entities
{
    public class CorrectionRequest: Entity<Guid>
    {
        public required Guid ArticleId { get; set; }
        public required Guid UserId { get; set; }
        public required string RequestContent { get; set; } = string.Empty;
        public required RecordStatu Status { get; set; } = RecordStatu.None;

        public Article Article { get; set; }
        public User User { get; set; }


        public CorrectionRequest()
        {

        }

        public CorrectionRequest(Guid articleId, Guid userId, string requestContent, RecordStatu statu)
        {
            ArticleId = articleId;
            UserId = userId;
            RequestContent = requestContent;
            Status = statu;
        }
    }
}
