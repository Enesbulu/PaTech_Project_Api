using Application.Features.Comments.Commands.Create;
using Application.Features.Comments.Commands.Delete;
using Application.Features.Comments.Commands.Update;
using Application.Features.Comments.Queries.GetById;
using Application.Features.Comments.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Core.Application.ResponseTypes.Concrete;
using webAPI.Controllers.Base;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommentsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCommentCommand createCommentCommand)
    {
        CustomResponseDto<CreatedCommentResponse> response = await Mediator.Send(createCommentCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCommentCommand updateCommentCommand)
    {
        CustomResponseDto<UpdatedCommentResponse> response = await Mediator.Send(updateCommentCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        CustomResponseDto<DeletedCommentResponse> response = await Mediator.Send(new DeleteCommentCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        CustomResponseDto<GetByIdCommentResponse> response = await Mediator.Send(new GetByIdCommentQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListCommentQuery getListCommentQuery = new() { PageRequest = pageRequest };
       CustomResponseDto<GetListResponse<GetListCommentListItemDto>> response = await Mediator.Send(getListCommentQuery);
        return Ok(response);
    }
}