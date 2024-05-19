using Core.Domain.Entities.Base;

namespace Core.Domain.Entities
{
    public class ArticlesTags:Entity<Guid>
    {
        public Guid ArticleId { get; set; }
        public Guid TagId { get; set; }
        public Article Article { get; set; }
        public Tag Tag { get; set; }
    }
}
