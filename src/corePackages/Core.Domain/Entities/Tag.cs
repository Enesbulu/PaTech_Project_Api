using Core.Domain.Entities.Base;

namespace Core.Domain.Entities
{
    public class Tag:Entity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<ArticlesTags> ArticleTags { get; set; }

        public Tag() { }

        public Tag(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
