using Application.Features.Authors.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Core.Domain.Entities;
using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Application.ResponseTypes.Concrete;
using System.Net;
using Core.Persistence.Paging;
using MediatR;
using static Application.Features.Authors.Constants.AuthorsOperationClaims;

namespace Application.Features.Authors.Queries.GetList;

public class GetListAuthorQuery : IRequest<CustomResponseDto<GetListResponse<GetListAuthorListItemDto>>>, ISecuredRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => new[] { Admin, Read };

    public class GetListAuthorQueryHandler : IRequestHandler<GetListAuthorQuery, CustomResponseDto<GetListResponse<GetListAuthorListItemDto>>>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public GetListAuthorQueryHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<GetListResponse<GetListAuthorListItemDto>>> Handle(GetListAuthorQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Author> authors = await _authorRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListAuthorListItemDto> response = _mapper.Map<GetListResponse<GetListAuthorListItemDto>>(authors);
             return CustomResponseDto<GetListResponse<GetListAuthorListItemDto>>.Success((int)HttpStatusCode.OK, response, true);
        }
    }
}