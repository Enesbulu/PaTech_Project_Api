using Application.Features.Comments.Constants;
using Application.Features.Comments.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.ResponseTypes.Concrete;
using System.Net;
using Core.Domain.Entities;
using Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Comments.Constants.CommentsOperationClaims;

namespace Application.Features.Comments.Commands.Create;

public class CreateCommentCommand : IRequest<CustomResponseDto<CreatedCommentResponse>>, ISecuredRequest
{

    public string[] Roles => new[] { Admin, Write, CommentsOperationClaims.Create };

    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, CustomResponseDto<CreatedCommentResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;
        private readonly CommentBusinessRules _commentBusinessRules;

        public CreateCommentCommandHandler(IMapper mapper, ICommentRepository commentRepository,
                                         CommentBusinessRules commentBusinessRules)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
            _commentBusinessRules = commentBusinessRules;
        }

        public async Task<CustomResponseDto<CreatedCommentResponse>> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            Comment comment = _mapper.Map<Comment>(request);

            await _commentRepository.AddAsync(comment);

            CreatedCommentResponse response = _mapper.Map<CreatedCommentResponse>(comment);
         return CustomResponseDto<CreatedCommentResponse>.Success((int)HttpStatusCode.OK, response, true);
        }
    }
}