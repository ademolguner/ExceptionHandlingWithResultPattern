using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Already;

public class AlreadyResponseCommand(string uuid, string name) : IRequest<ResponseModelDto>
{
    public string Uuid { get; set; } = uuid;
    public string Name { get; set; } = name;
}