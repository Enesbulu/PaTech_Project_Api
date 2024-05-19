using Application.Features.Comments.Constants;
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

namespace Application.Features.Comments.Commands.Delete;

public class DeleteCommentCommand : IRequest<CustomResponseDto<DeletedCommentResponse>>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => new[] { Admin, Write, CommentsOperationClaims.Delete };

    public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommand, CustomResponseDto<DeletedCommentResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;
        private readonly CommentBusinessRules _commentBusinessRules;

        public DeleteCommentCommandHandler(IMapper mapper, ICommentRepository commentRepository,
                                         CommentBusinessRules commentBusinessRules)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
            _commentBusinessRules = commentBusinessRules;
        }

        public async Task<CustomResponseDto<DeletedCommentResponse>> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            Comment? comment = await _commentRepository.GetAsync(predicate: c => c.Id == request.Id, cancellationToken: cancellationToken);
            await _commentBusinessRules.CommentShouldExistWhenSelected(comment);

            await _commentRepository.DeleteAsync(comment!);

            DeletedCommentResponse response = _mapper.Map<DeletedCommentResponse>(comment);

             return CustomResponseDto<DeletedCommentResponse>.Success((int)HttpStatusCode.OK, response, true);

        }
    }
}