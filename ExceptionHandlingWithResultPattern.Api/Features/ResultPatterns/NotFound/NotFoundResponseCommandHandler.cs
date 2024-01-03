using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.NotFound;

public class NotFoundResponseCommandHandler:IRequestHandler<NotFoundResponseCommand,ResponseModelDto>
{
    public Task<ResponseModelDto> Handle(NotFoundResponseCommand request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}