using Application.Features.CorrectionRequests.Commands.Create;
using Application.Features.CorrectionRequests.Commands.Delete;
using Application.Features.CorrectionRequests.Commands.Update;
using Application.Features.CorrectionRequests.Queries.GetById;
using Application.Features.CorrectionRequests.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Core.Application.ResponseTypes.Concrete;
using webAPI.Controllers.Base;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CorrectionRequestsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCorrectionRequestCommand createCorrectionRequestCommand)
    {
        CustomResponseDto<CreatedCorrectionRequestResponse> response = await Mediator.Send(createCorrectionRequestCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCorrectionRequestCommand updateCorrectionRequestCommand)
    {
        CustomResponseDto<UpdatedCorrectionRequestResponse> response = await Mediator.Send(updateCorrectionRequestCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        CustomResponseDto<DeletedCorrectionRequestResponse> response = await Mediator.Send(new DeleteCorrectionRequestCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        CustomResponseDto<GetByIdCorrectionRequestResponse> response = await Mediator.Send(new GetByIdCorrectionRequestQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListCorrectionRequestQuery getListCorrectionRequestQuery = new() { PageRequest = pageRequest };
       CustomResponseDto<GetListResponse<GetListCorrectionRequestListItemDto>> response = await Mediator.Send(getListCorrectionRequestQuery);
        return Ok(response);
    }
}