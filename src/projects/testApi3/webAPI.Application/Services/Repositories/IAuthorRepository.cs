using Core.Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IAuthorRepository : IAsyncRepository<Author, Guid>, IRepository<Author, Guid>
{
}