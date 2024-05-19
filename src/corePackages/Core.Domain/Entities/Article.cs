using Core.Domain.Entities.Base;

namespace Core.Domain.Entities
{
    public class Article : Entity<Guid>
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public Guid CategoryId { get; set; }
        public required bool IsApproved { get; set; }
        public DateTime? ApprovalDate { get; set; } = default(DateTime?);



        //public required Guid AuthorId { get; set; } = default!;
        //public required Guid EditorId { get; set; } = default!;

        public Category Category { get; set; }
        public IEnumerable<Comment?> Comment { get; set; } = default;
        public IEnumerable<CorrectionRequest?> CorrectionRequest { get; set; } = default;
        public ICollection<ArticlesTags> ArticleTags { get; set; }
        //public Author Author { get; set; }
        //public Editor Editor { get; set; }

        public Article( )
        {
            Category = default!;
        }

        public Article(Guid id, string title, string content, string thumbnail, DateTime date, int viewCount, int commentCount, Guid categoryId, ICollection<ArticlesTags> articleTags, bool isApproved, DateTime? approvalDate)
        {
            Id = id;
            Title = title;
            Content = content;
            Thumbnail = thumbnail;
            Date = date;
            ViewCount = viewCount;
            CommentCount = commentCount;
            CategoryId = categoryId;
            //AuthorId = authorId;
            //EditorId = editorId;
            Category = default!;
            ArticleTags = articleTags;
            IsApproved = isApproved;
            ApprovalDate = approvalDate;
        }

    }
}
