using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.NotFound;

public class NotFoundResponseCommandHandler:IRequestHandler<NotFoundResponseCommand,GenericResult<ResponseModelDto>>
{
    public Task<GenericResult<ResponseModelDto>> Handle(NotFoundResponseCommand request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}