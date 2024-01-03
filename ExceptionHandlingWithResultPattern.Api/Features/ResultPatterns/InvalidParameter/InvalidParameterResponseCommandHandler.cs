using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.InvalidParameter;

public class InvalidParameterResponseCommandHandler:IRequestHandler<InvalidParameterResponseCommand,ResponseModelDto>
{
    public Task<ResponseModelDto> Handle(InvalidParameterResponseCommand request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}