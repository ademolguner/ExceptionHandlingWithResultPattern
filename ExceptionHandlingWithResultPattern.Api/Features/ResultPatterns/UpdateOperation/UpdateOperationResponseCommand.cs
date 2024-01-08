using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.UpdateOperation;

public class UpdateOperationResponseCommand(string userId, string name) : IRequest<GenericResult<ResponseModelDto>>
{
    public string UserId { get; set; } = userId;
    public string Name { get; set; } = name;
}