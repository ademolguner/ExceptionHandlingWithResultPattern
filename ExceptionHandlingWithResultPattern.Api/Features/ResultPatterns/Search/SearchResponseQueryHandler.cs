using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Search;

public class SearchResponseQueryHandler:IRequestHandler<SearchResponseQuery,ResponseModelDto>
{
    public Task<ResponseModelDto> Handle(SearchResponseQuery request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}