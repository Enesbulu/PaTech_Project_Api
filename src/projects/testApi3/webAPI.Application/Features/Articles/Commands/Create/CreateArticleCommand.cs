using Application.Features.Articles.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.ResponseTypes.Concrete;
using System.Net;
using Core.Domain.Entities;
using MediatR;

namespace Application.Features.Articles.Commands.Create;

public class CreateArticleCommand : IRequest<CustomResponseDto<CreatedArticleResponse>>
{
    public DateTime Date { get; set; }
    public int ViewCount { get; set; }
    public int CommentCount { get; set; }
    public Guid CategoryId { get; set; }

    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, CustomResponseDto<CreatedArticleResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IArticleRepository _articleRepository;
        private readonly ArticleBusinessRules _articleBusinessRules;

        public CreateArticleCommandHandler(IMapper mapper, IArticleRepository articleRepository,
                                         ArticleBusinessRules articleBusinessRules)
        {
            _mapper = mapper;
            _articleRepository = articleRepository;
            _articleBusinessRules = articleBusinessRules;
        }

        public async Task<CustomResponseDto<CreatedArticleResponse>> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            Article article = _mapper.Map<Article>(request);

            await _articleRepository.AddAsync(article);

            CreatedArticleResponse response = _mapper.Map<CreatedArticleResponse>(article);
         return CustomResponseDto<CreatedArticleResponse>.Success((int)HttpStatusCode.OK, response, true);
        }
    }
}