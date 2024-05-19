using Application.Features.CorrectionRequests.Commands.Create;
using Application.Features.CorrectionRequests.Commands.Delete;
using Application.Features.CorrectionRequests.Commands.Update;
using Application.Features.CorrectionRequests.Queries.GetById;
using Application.Features.CorrectionRequests.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Domain.Entities;
using Core.Persistence.Paging;

namespace Application.Features.CorrectionRequests.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CorrectionRequest, CreateCorrectionRequestCommand>().ReverseMap();
        CreateMap<CorrectionRequest, CreatedCorrectionRequestResponse>().ReverseMap();
        CreateMap<CorrectionRequest, UpdateCorrectionRequestCommand>().ReverseMap();
        CreateMap<CorrectionRequest, UpdatedCorrectionRequestResponse>().ReverseMap();
        CreateMap<CorrectionRequest, DeleteCorrectionRequestCommand>().ReverseMap();
        CreateMap<CorrectionRequest, DeletedCorrectionRequestResponse>().ReverseMap();
        CreateMap<CorrectionRequest, GetByIdCorrectionRequestResponse>().ReverseMap();
        CreateMap<CorrectionRequest, GetListCorrectionRequestListItemDto>().ReverseMap();
        CreateMap<IPaginate<CorrectionRequest>, GetListResponse<GetListCorrectionRequestListItemDto>>().ReverseMap();
    }
}