using Application.Features.CorrectionRequests.Rules;
using Application.Services.Repositories;
using Core.Persistence.Paging;
using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.CorrectionRequests;

public class CorrectionRequestsManager : ICorrectionRequestsService
{
    private readonly ICorrectionRequestRepository _correctionRequestRepository;
    private readonly CorrectionRequestBusinessRules _correctionRequestBusinessRules;

    public CorrectionRequestsManager(ICorrectionRequestRepository correctionRequestRepository, CorrectionRequestBusinessRules correctionRequestBusinessRules)
    {
        _correctionRequestRepository = correctionRequestRepository;
        _correctionRequestBusinessRules = correctionRequestBusinessRules;
    }

    public async Task<CorrectionRequest?> GetAsync(
        Expression<Func<CorrectionRequest, bool>> predicate,
        Func<IQueryable<CorrectionRequest>, IIncludableQueryable<CorrectionRequest, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        CorrectionRequest? correctionRequest = await _correctionRequestRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return correctionRequest;
    }

    public async Task<IPaginate<CorrectionRequest>?> GetListAsync(
        Expression<Func<CorrectionRequest, bool>>? predicate = null,
        Func<IQueryable<CorrectionRequest>, IOrderedQueryable<CorrectionRequest>>? orderBy = null,
        Func<IQueryable<CorrectionRequest>, IIncludableQueryable<CorrectionRequest, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<CorrectionRequest> correctionRequestList = await _correctionRequestRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return correctionRequestList;
    }

    public async Task<CorrectionRequest> AddAsync(CorrectionRequest correctionRequest)
    {
        CorrectionRequest addedCorrectionRequest = await _correctionRequestRepository.AddAsync(correctionRequest);

        return addedCorrectionRequest;
    }

    public async Task<CorrectionRequest> UpdateAsync(CorrectionRequest correctionRequest)
    {
        CorrectionRequest updatedCorrectionRequest = await _correctionRequestRepository.UpdateAsync(correctionRequest);

        return updatedCorrectionRequest;
    }

    public async Task<CorrectionRequest> DeleteAsync(CorrectionRequest correctionRequest, bool permanent = false)
    {
        CorrectionRequest deletedCorrectionRequest = await _correctionRequestRepository.DeleteAsync(correctionRequest);

        return deletedCorrectionRequest;
    }
}
