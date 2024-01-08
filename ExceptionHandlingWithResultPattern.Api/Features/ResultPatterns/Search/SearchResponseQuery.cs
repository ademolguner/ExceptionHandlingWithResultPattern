using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Search;

public class SearchResponseQuery(string name) : IRequest<GenericResult<ResponseModelDto>>
{
    public string Name { get; set; } = name;
}