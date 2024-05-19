using Core.Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ICorrectionRequestRepository : IAsyncRepository<CorrectionRequest, Guid>, IRepository<CorrectionRequest, Guid>
{
}