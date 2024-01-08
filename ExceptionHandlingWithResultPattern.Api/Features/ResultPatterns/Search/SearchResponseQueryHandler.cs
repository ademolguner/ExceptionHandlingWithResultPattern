using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Search;

public class SearchResponseQueryHandler:IRequestHandler<SearchResponseQuery,GenericResult<ResponseModelDto>>
{
    public Task<GenericResult<ResponseModelDto>> Handle(SearchResponseQuery request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}