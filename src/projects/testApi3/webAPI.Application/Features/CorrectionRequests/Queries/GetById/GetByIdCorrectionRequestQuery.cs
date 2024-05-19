using Application.Features.CorrectionRequests.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.ResponseTypes.Concrete;
using System.Net;
using Core.Domain.Entities;
using MediatR;

namespace Application.Features.CorrectionRequests.Queries.GetById;

public class GetByIdCorrectionRequestQuery : IRequest<CustomResponseDto<GetByIdCorrectionRequestResponse>>
{
    public Guid Id { get; set; }

    public class GetByIdCorrectionRequestQueryHandler : IRequestHandler<GetByIdCorrectionRequestQuery, CustomResponseDto<GetByIdCorrectionRequestResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ICorrectionRequestRepository _correctionRequestRepository;
        private readonly CorrectionRequestBusinessRules _correctionRequestBusinessRules;

        public GetByIdCorrectionRequestQueryHandler(IMapper mapper, ICorrectionRequestRepository correctionRequestRepository, CorrectionRequestBusinessRules correctionRequestBusinessRules)
        {
            _mapper = mapper;
            _correctionRequestRepository = correctionRequestRepository;
            _correctionRequestBusinessRules = correctionRequestBusinessRules;
        }

        public async Task<CustomResponseDto<GetByIdCorrectionRequestResponse>> Handle(GetByIdCorrectionRequestQuery request, CancellationToken cancellationToken)
        {
            CorrectionRequest? correctionRequest = await _correctionRequestRepository.GetAsync(predicate: cr => cr.Id == request.Id, cancellationToken: cancellationToken);
            await _correctionRequestBusinessRules.CorrectionRequestShouldExistWhenSelected(correctionRequest);

            GetByIdCorrectionRequestResponse response = _mapper.Map<GetByIdCorrectionRequestResponse>(correctionRequest);

          return CustomResponseDto<GetByIdCorrectionRequestResponse>.Success((int)HttpStatusCode.OK, response, true);
        }
    }
}