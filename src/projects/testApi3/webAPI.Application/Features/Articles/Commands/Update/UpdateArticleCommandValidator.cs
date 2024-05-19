using FluentValidation;

namespace Application.Features.Articles.Commands.Update;

public class UpdateArticleCommandValidator : AbstractValidator<UpdateArticleCommand>
{
    public UpdateArticleCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Date).NotEmpty();
        RuleFor(c => c.ViewCount).NotEmpty();
        RuleFor(c => c.CommentCount).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
    }
}