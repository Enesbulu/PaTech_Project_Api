using FluentValidation;

namespace Application.Features.Articles.Commands.Create;

public class CreateArticleCommandValidator : AbstractValidator<CreateArticleCommand>
{
    public CreateArticleCommandValidator()
    {
        RuleFor(c => c.Date).NotEmpty();
        RuleFor(c => c.ViewCount).NotEmpty();
        RuleFor(c => c.CommentCount).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
    }
}