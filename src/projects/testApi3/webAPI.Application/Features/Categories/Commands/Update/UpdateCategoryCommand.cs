using Application.Features.Categories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.ResponseTypes.Concrete;
using System.Net;
using Core.Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Update;

public class UpdateCategoryCommand : IRequest<CustomResponseDto<UpdatedCategoryResponse>>
{
    public Guid Id { get; set; }

    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, CustomResponseDto<UpdatedCategoryResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        private readonly CategoryBusinessRules _categoryBusinessRules;

        public UpdateCategoryCommandHandler(IMapper mapper, ICategoryRepository categoryRepository,
                                         CategoryBusinessRules categoryBusinessRules)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _categoryBusinessRules = categoryBusinessRules;
        }

        public async Task<CustomResponseDto<UpdatedCategoryResponse>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category? category = await _categoryRepository.GetAsync(predicate: c => c.Id == request.Id, cancellationToken: cancellationToken);
            await _categoryBusinessRules.CategoryShouldExistWhenSelected(category);
            category = _mapper.Map(request, category);

            await _categoryRepository.UpdateAsync(category!);

            UpdatedCategoryResponse response = _mapper.Map<UpdatedCategoryResponse>(category);

          return CustomResponseDto<UpdatedCategoryResponse>.Success((int)HttpStatusCode.OK, response, true);
        }
    }
}