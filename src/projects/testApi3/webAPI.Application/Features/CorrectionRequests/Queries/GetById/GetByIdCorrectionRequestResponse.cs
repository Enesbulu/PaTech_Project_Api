using Core.Application.Responses;

namespace Application.Features.CorrectionRequests.Queries.GetById;

public class GetByIdCorrectionRequestResponse : IResponse
{
    public Guid Id { get; set; }
}