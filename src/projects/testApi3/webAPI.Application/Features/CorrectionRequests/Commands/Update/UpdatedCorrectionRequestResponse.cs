using Core.Application.Responses;

namespace Application.Features.CorrectionRequests.Commands.Update;

public class UpdatedCorrectionRequestResponse : IResponse
{
    public Guid Id { get; set; }
}