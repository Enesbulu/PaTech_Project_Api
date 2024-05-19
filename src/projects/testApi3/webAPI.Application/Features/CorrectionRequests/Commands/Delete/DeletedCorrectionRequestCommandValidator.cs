using FluentValidation;

namespace Application.Features.CorrectionRequests.Commands.Delete;

public class DeleteCorrectionRequestCommandValidator : AbstractValidator<DeleteCorrectionRequestCommand>
{
    public DeleteCorrectionRequestCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}