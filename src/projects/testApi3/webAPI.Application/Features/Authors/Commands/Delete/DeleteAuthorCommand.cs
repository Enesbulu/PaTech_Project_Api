using Application.Features.Authors.Constants;
using Application.Features.Authors.Constants;
using Application.Features.Authors.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.ResponseTypes.Concrete;
using System.Net;
using Core.Domain.Entities;
using Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Authors.Constants.AuthorsOperationClaims;

namespace Application.Features.Authors.Commands.Delete;

public class DeleteAuthorCommand : IRequest<CustomResponseDto<DeletedAuthorResponse>>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => new[] { Admin, Write, AuthorsOperationClaims.Delete };

    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand, CustomResponseDto<DeletedAuthorResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;
        private readonly AuthorBusinessRules _authorBusinessRules;

        public DeleteAuthorCommandHandler(IMapper mapper, IAuthorRepository authorRepository,
                                         AuthorBusinessRules authorBusinessRules)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;
            _authorBusinessRules = authorBusinessRules;
        }

        public async Task<CustomResponseDto<DeletedAuthorResponse>> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            Author? author = await _authorRepository.GetAsync(predicate: a => a.Id == request.Id, cancellationToken: cancellationToken);
            await _authorBusinessRules.AuthorShouldExistWhenSelected(author);

            await _authorRepository.DeleteAsync(author!);

            DeletedAuthorResponse response = _mapper.Map<DeletedAuthorResponse>(author);

             return CustomResponseDto<DeletedAuthorResponse>.Success((int)HttpStatusCode.OK, response, true);

        }
    }
}