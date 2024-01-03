using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Fail;

public class FailResponseQuerydHandler:IRequestHandler<FailResponseQuery,ResponseModelDto>
{
    public Task<ResponseModelDto> Handle(FailResponseQuery request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}