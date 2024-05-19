using Application.Features.CorrectionRequests.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.ResponseTypes.Concrete;
using System.Net;
using Core.Domain.Entities;
using MediatR;

namespace Application.Features.CorrectionRequests.Commands.Update;

public class UpdateCorrectionRequestCommand : IRequest<CustomResponseDto<UpdatedCorrectionRequestResponse>>
{
    public Guid Id { get; set; }

    public class UpdateCorrectionRequestCommandHandler : IRequestHandler<UpdateCorrectionRequestCommand, CustomResponseDto<UpdatedCorrectionRequestResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ICorrectionRequestRepository _correctionRequestRepository;
        private readonly CorrectionRequestBusinessRules _correctionRequestBusinessRules;

        public UpdateCorrectionRequestCommandHandler(IMapper mapper, ICorrectionRequestRepository correctionRequestRepository,
                                         CorrectionRequestBusinessRules correctionRequestBusinessRules)
        {
            _mapper = mapper;
            _correctionRequestRepository = correctionRequestRepository;
            _correctionRequestBusinessRules = correctionRequestBusinessRules;
        }

        public async Task<CustomResponseDto<UpdatedCorrectionRequestResponse>> Handle(UpdateCorrectionRequestCommand request, CancellationToken cancellationToken)
        {
            CorrectionRequest? correctionRequest = await _correctionRequestRepository.GetAsync(predicate: cr => cr.Id == request.Id, cancellationToken: cancellationToken);
            await _correctionRequestBusinessRules.CorrectionRequestShouldExistWhenSelected(correctionRequest);
            correctionRequest = _mapper.Map(request, correctionRequest);

            await _correctionRequestRepository.UpdateAsync(correctionRequest!);

            UpdatedCorrectionRequestResponse response = _mapper.Map<UpdatedCorrectionRequestResponse>(correctionRequest);

          return CustomResponseDto<UpdatedCorrectionRequestResponse>.Success((int)HttpStatusCode.OK, response, true);
        }
    }
}