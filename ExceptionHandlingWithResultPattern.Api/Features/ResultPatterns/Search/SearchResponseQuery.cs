using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Search;

public class SearchResponseQuery(string name) : IRequest<ResponseModelDto>
{
    public string Name { get; set; } = name;
}