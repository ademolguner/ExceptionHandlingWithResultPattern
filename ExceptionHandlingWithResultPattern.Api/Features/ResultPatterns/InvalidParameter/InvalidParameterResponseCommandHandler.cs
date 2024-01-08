using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.InvalidParameter;

public class InvalidParameterResponseCommandHandler:IRequestHandler<InvalidParameterResponseCommand,GenericResult<ResponseModelDto>>
{
    public Task<GenericResult<ResponseModelDto>> Handle(InvalidParameterResponseCommand request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}