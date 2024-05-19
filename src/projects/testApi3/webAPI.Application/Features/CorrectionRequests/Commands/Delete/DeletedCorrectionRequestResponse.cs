using Core.Application.Responses;

namespace Application.Features.CorrectionRequests.Commands.Delete;

public class DeletedCorrectionRequestResponse : IResponse
{
    public Guid Id { get; set; }
}