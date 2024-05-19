using Application.Features.CorrectionRequests.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Domain.Entities;

namespace Application.Features.CorrectionRequests.Rules;

public class CorrectionRequestBusinessRules : BaseBusinessRules
{
    private readonly ICorrectionRequestRepository _correctionRequestRepository;

    public CorrectionRequestBusinessRules(ICorrectionRequestRepository correctionRequestRepository)
    {
        _correctionRequestRepository = correctionRequestRepository;
    }

    public Task CorrectionRequestShouldExistWhenSelected(CorrectionRequest? correctionRequest)
    {
        if (correctionRequest == null)
            throw new BusinessException(CorrectionRequestsBusinessMessages.CorrectionRequestNotExists);
        return Task.CompletedTask;
    }

    public async Task CorrectionRequestIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        CorrectionRequest? correctionRequest = await _correctionRequestRepository.GetAsync(
            predicate: cr => cr.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await CorrectionRequestShouldExistWhenSelected(correctionRequest);
    }
}