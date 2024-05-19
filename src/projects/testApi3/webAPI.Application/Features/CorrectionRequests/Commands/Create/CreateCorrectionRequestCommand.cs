using Application.Features.CorrectionRequests.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.ResponseTypes.Concrete;
using System.Net;
using Core.Domain.Entities;
using MediatR;

namespace Application.Features.CorrectionRequests.Commands.Create;

public class CreateCorrectionRequestCommand : IRequest<CustomResponseDto<CreatedCorrectionRequestResponse>>
{

    public class CreateCorrectionRequestCommandHandler : IRequestHandler<CreateCorrectionRequestCommand, CustomResponseDto<CreatedCorrectionRequestResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ICorrectionRequestRepository _correctionRequestRepository;
        private readonly CorrectionRequestBusinessRules _correctionRequestBusinessRules;

        public CreateCorrectionRequestCommandHandler(IMapper mapper, ICorrectionRequestRepository correctionRequestRepository,
                                         CorrectionRequestBusinessRules correctionRequestBusinessRules)
        {
            _mapper = mapper;
            _correctionRequestRepository = correctionRequestRepository;
            _correctionRequestBusinessRules = correctionRequestBusinessRules;
        }

        public async Task<CustomResponseDto<CreatedCorrectionRequestResponse>> Handle(CreateCorrectionRequestCommand request, CancellationToken cancellationToken)
        {
            CorrectionRequest correctionRequest = _mapper.Map<CorrectionRequest>(request);

            await _correctionRequestRepository.AddAsync(correctionRequest);

            CreatedCorrectionRequestResponse response = _mapper.Map<CreatedCorrectionRequestResponse>(correctionRequest);
         return CustomResponseDto<CreatedCorrectionRequestResponse>.Success((int)HttpStatusCode.OK, response, true);
        }
    }
}