using Core.Application.Responses;

namespace Application.Features.CorrectionRequests.Commands.Create;

public class CreatedCorrectionRequestResponse : IResponse
{
    public Guid Id { get; set; }
}