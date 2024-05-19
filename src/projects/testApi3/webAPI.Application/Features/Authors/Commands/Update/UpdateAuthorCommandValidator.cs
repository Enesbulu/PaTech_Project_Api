using FluentValidation;

namespace Application.Features.Authors.Commands.Update;

public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
{
    public UpdateAuthorCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.CreatedBy).NotEmpty();
        RuleFor(c => c.CreatedDate).NotEmpty();
        RuleFor(c => c.ModifiedBy).NotEmpty();
        RuleFor(c => c.IsDeleted).NotEmpty();
    }
}