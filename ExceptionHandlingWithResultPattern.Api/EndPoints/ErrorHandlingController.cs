using ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Already;
using ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.CreateOperation;
using ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Fail;
using ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.InvalidParameter;
using ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Search;
using ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Success;
using ExceptionHandlingWithResultPattern.Api.Models.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandlingWithResultPattern.Api.EndPoints;

public static class ErrorHandlingController
{
    public static void MapExceptionEndpoints(this IEndpointRouteBuilder app)
    {
        var appGroup = app.MapGroup("api/exception-handling-with-result-pattern");
        appGroup.MapPost("/already-exception", AlreadyAsync).WithName(nameof(AlreadyAsync));
        appGroup.MapPost("/invalid-parameter-exception", InvalidParameterAsync).WithName(nameof(InvalidParameterAsync));
        appGroup.MapPost("/create-operation-exception", CreateOperationAsync).WithName(nameof(CreateOperationAsync));
        appGroup.MapPost("/not-found-exception", NotFoundAsync).WithName(nameof(NotFoundAsync));
        appGroup.MapPost("/update-operation-exception", UpdateOperationAsync).WithName(nameof(UpdateOperationAsync));
        appGroup.MapPost("/fail", FailAsync).WithName(nameof(FailAsync));
        appGroup.MapPost("/success", SuccessAsync).WithName(nameof(SuccessAsync));
    }
    
    [HttpPost("error/already-exception")]
    private static async Task<IResult> AlreadyAsync([FromBody] AlreadyRequest request,IMediator sender)
    {
        var response = await sender.Send(new AlreadyResponseCommand(request.UserId,request.Name));
        return Results.Ok(response);
    }
    
    [HttpPost("error/invalid-parameter-exception")]
    private static async  Task<IResult> InvalidParameterAsync([FromBody] InvalidRequest request,IMediator sender)
    {
        var response = await sender.Send(new InvalidParameterResponseCommand(request.UserId,request.Name));
        return Results.Ok(response);
    }
    
    [HttpPost("error/create-operation-exception")]
    private static async Task<IResult> CreateOperationAsync([FromBody] CreateRequest request,IMediator sender)
    {
        var response = await sender.Send(new CreateOperationResponseCommand(request.UserId,request.Name));
        return Results.Ok(response);
    }
    
    [HttpPost("error/not-found-exception")]
    private static async Task<IResult> NotFoundAsync([FromBody] SearchRequest request,IMediator sender)
    {
        var response = await sender.Send(new SearchResponseQuery(request.Name));
        return Results.Ok(response);
    }
    
    [HttpPost("error/update-operation-exception")]
    private static async Task<IResult> UpdateOperationAsync([FromBody] UpdateRequest request,IMediator sender)
    {
        var response = await sender.Send(new AlreadyResponseCommand(request.UserId,request.Name));
        return Results.Ok(response);
    }
    
    [HttpPost("fail")]
    private static async Task<IResult> FailAsync([FromBody] FailRequest request,IMediator sender)
    {
        var response = await sender.Send(new FailResponseQuery(request.UserId,request.Name));
        return Results.Ok(response);
    }
    
    [HttpPost("success")]
    private static async Task<IResult> SuccessAsync([FromBody] SuccessRequest request,IMediator sender)
    {
        var response = await sender.Send(new SuccessResponseCommand(request.UserId,request.Name));
        return Results.Ok(response);
    }
}