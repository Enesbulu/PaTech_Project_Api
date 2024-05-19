using Core.Application.Responses;

namespace Application.Features.Articles.Queries.GetById;

public class GetByIdArticleResponse : IResponse
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public int ViewCount { get; set; }
    public int CommentCount { get; set; }
    public Guid CategoryId { get; set; }
}