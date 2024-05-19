using Application.Features.Articles.Commands.Create;
using Application.Features.Articles.Commands.Delete;
using Application.Features.Articles.Commands.Update;
using Application.Features.Articles.Queries.GetById;
using Application.Features.Articles.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Core.Application.ResponseTypes.Concrete;
using webAPI.Controllers.Base;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArticlesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateArticleCommand createArticleCommand)
    {
        CustomResponseDto<CreatedArticleResponse> response = await Mediator.Send(createArticleCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateArticleCommand updateArticleCommand)
    {
        CustomResponseDto<UpdatedArticleResponse> response = await Mediator.Send(updateArticleCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        CustomResponseDto<DeletedArticleResponse> response = await Mediator.Send(new DeleteArticleCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        CustomResponseDto<GetByIdArticleResponse> response = await Mediator.Send(new GetByIdArticleQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListArticleQuery getListArticleQuery = new() { PageRequest = pageRequest };
       CustomResponseDto<GetListResponse<GetListArticleListItemDto>> response = await Mediator.Send(getListArticleQuery);
        return Ok(response);
    }
}