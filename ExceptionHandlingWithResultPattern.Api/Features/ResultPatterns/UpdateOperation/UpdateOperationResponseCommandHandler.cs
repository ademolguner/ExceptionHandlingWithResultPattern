using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.UpdateOperation;

public class UpdateOperationResponseCommandHandler:IRequestHandler<UpdateOperationResponseCommand,ResponseModelDto>
{
    public Task<ResponseModelDto> Handle(UpdateOperationResponseCommand request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}