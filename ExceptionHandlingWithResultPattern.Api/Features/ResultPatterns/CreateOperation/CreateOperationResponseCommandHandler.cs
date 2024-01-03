using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.CreateOperation;

public class CreateOperationResponseCommandHandler:IRequestHandler<CreateOperationResponseCommand,ResponseModelDto>
{
    public Task<ResponseModelDto> Handle(CreateOperationResponseCommand request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}