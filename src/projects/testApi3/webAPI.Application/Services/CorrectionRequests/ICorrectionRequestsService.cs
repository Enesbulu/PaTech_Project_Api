using Core.Persistence.Paging;
using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.CorrectionRequests;

public interface ICorrectionRequestsService
{
    Task<CorrectionRequest?> GetAsync(
        Expression<Func<CorrectionRequest, bool>> predicate,
        Func<IQueryable<CorrectionRequest>, IIncludableQueryable<CorrectionRequest, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<CorrectionRequest>?> GetListAsync(
        Expression<Func<CorrectionRequest, bool>>? predicate = null,
        Func<IQueryable<CorrectionRequest>, IOrderedQueryable<CorrectionRequest>>? orderBy = null,
        Func<IQueryable<CorrectionRequest>, IIncludableQueryable<CorrectionRequest, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<CorrectionRequest> AddAsync(CorrectionRequest correctionRequest);
    Task<CorrectionRequest> UpdateAsync(CorrectionRequest correctionRequest);
    Task<CorrectionRequest> DeleteAsync(CorrectionRequest correctionRequest, bool permanent = false);
}
