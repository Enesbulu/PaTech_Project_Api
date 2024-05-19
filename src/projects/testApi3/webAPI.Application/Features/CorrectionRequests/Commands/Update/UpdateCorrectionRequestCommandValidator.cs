using FluentValidation;

namespace Application.Features.CorrectionRequests.Commands.Update;

public class UpdateCorrectionRequestCommandValidator : AbstractValidator<UpdateCorrectionRequestCommand>
{
    public UpdateCorrectionRequestCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}