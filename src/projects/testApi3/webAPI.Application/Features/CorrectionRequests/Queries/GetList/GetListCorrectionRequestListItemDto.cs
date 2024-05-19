using Core.Application.Dtos;

namespace Application.Features.CorrectionRequests.Queries.GetList;

public class GetListCorrectionRequestListItemDto : IDto
{
    public Guid Id { get; set; }
}