using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.InvalidParameter;

public class InvalidParameterResponseCommand(string uuid, string name) : IRequest<ResponseModelDto>
{
    public string Uuid { get; set; } = uuid;
    public string Name { get; set; } = name;
}