using Application.Services.Repositories;
using AutoMapper;
using Core.Domain.Entities;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Application.ResponseTypes.Concrete;
using System.Net;
using Core.Persistence.Paging;
using MediatR;

namespace Application.Features.CorrectionRequests.Queries.GetList;

public class GetListCorrectionRequestQuery : IRequest<CustomResponseDto<GetListResponse<GetListCorrectionRequestListItemDto>>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListCorrectionRequestQueryHandler : IRequestHandler<GetListCorrectionRequestQuery, CustomResponseDto<GetListResponse<GetListCorrectionRequestListItemDto>>>
    {
        private readonly ICorrectionRequestRepository _correctionRequestRepository;
        private readonly IMapper _mapper;

        public GetListCorrectionRequestQueryHandler(ICorrectionRequestRepository correctionRequestRepository, IMapper mapper)
        {
            _correctionRequestRepository = correctionRequestRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<GetListResponse<GetListCorrectionRequestListItemDto>>> Handle(GetListCorrectionRequestQuery request, CancellationToken cancellationToken)
        {
            IPaginate<CorrectionRequest> correctionRequests = await _correctionRequestRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListCorrectionRequestListItemDto> response = _mapper.Map<GetListResponse<GetListCorrectionRequestListItemDto>>(correctionRequests);
             return CustomResponseDto<GetListResponse<GetListCorrectionRequestListItemDto>>.Success((int)HttpStatusCode.OK, response, true);
        }
    }
}