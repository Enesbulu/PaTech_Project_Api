using Application.Features.CorrectionRequests.Constants;
using Application.Features.CorrectionRequests.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.ResponseTypes.Concrete;
using System.Net;
using Core.Domain.Entities;
using MediatR;

namespace Application.Features.CorrectionRequests.Commands.Delete;

public class DeleteCorrectionRequestCommand : IRequest<CustomResponseDto<DeletedCorrectionRequestResponse>>
{
    public Guid Id { get; set; }

    public class DeleteCorrectionRequestCommandHandler : IRequestHandler<DeleteCorrectionRequestCommand, CustomResponseDto<DeletedCorrectionRequestResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ICorrectionRequestRepository _correctionRequestRepository;
        private readonly CorrectionRequestBusinessRules _correctionRequestBusinessRules;

        public DeleteCorrectionRequestCommandHandler(IMapper mapper, ICorrectionRequestRepository correctionRequestRepository,
                                         CorrectionRequestBusinessRules correctionRequestBusinessRules)
        {
            _mapper = mapper;
            _correctionRequestRepository = correctionRequestRepository;
            _correctionRequestBusinessRules = correctionRequestBusinessRules;
        }

        public async Task<CustomResponseDto<DeletedCorrectionRequestResponse>> Handle(DeleteCorrectionRequestCommand request, CancellationToken cancellationToken)
        {
            CorrectionRequest? correctionRequest = await _correctionRequestRepository.GetAsync(predicate: cr => cr.Id == request.Id, cancellationToken: cancellationToken);
            await _correctionRequestBusinessRules.CorrectionRequestShouldExistWhenSelected(correctionRequest);

            await _correctionRequestRepository.DeleteAsync(correctionRequest!);

            DeletedCorrectionRequestResponse response = _mapper.Map<DeletedCorrectionRequestResponse>(correctionRequest);

             return CustomResponseDto<DeletedCorrectionRequestResponse>.Success((int)HttpStatusCode.OK, response, true);

        }
    }
}