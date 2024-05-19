using Core.Application.Dtos;

namespace Application.Features.Articles.Queries.GetList;

public class GetListArticleListItemDto : IDto
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public int ViewCount { get; set; }
    public int CommentCount { get; set; }
    public Guid CategoryId { get; set; }
}