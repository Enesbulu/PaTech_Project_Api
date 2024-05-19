using Core.Application.Responses;

namespace Application.Features.Articles.Commands.Update;

public class UpdatedArticleResponse : IResponse
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public int ViewCount { get; set; }
    public int CommentCount { get; set; }
    public Guid CategoryId { get; set; }
}