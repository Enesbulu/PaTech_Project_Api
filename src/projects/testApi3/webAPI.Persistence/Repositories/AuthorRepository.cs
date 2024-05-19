using Application.Services.Repositories;
using Core.Domain.Entities;
using Core.Persistence.Contexts;
using Core.Persistence.Repositories;

namespace Persistence.Repositories;

public class AuthorRepository : EfRepositoryBase<Author, Guid, BaseDbContext>, IAuthorRepository
{
    public AuthorRepository(BaseDbContext context) : base(context)
    {
    }
}