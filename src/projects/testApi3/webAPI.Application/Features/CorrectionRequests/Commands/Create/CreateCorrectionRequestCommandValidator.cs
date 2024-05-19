using FluentValidation;

namespace Application.Features.CorrectionRequests.Commands.Create;

public class CreateCorrectionRequestCommandValidator : AbstractValidator<CreateCorrectionRequestCommand>
{
    public CreateCorrectionRequestCommandValidator()
    {
    }
}