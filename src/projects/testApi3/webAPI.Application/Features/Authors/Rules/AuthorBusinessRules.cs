using Application.Features.Authors.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Domain.Entities;

namespace Application.Features.Authors.Rules;

public class AuthorBusinessRules : BaseBusinessRules
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorBusinessRules(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public Task AuthorShouldExistWhenSelected(Author? author)
    {
        if (author == null)
            throw new BusinessException(AuthorsBusinessMessages.AuthorNotExists);
        return Task.CompletedTask;
    }

    public async Task AuthorIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Author? author = await _authorRepository.GetAsync(
            predicate: a => a.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await AuthorShouldExistWhenSelected(author);
    }
}