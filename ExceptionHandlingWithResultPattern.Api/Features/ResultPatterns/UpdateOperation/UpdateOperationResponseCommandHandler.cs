using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.UpdateOperation;

public class UpdateOperationResponseCommandHandler:IRequestHandler<UpdateOperationResponseCommand,GenericResult<ResponseModelDto>>
{
    public Task<GenericResult<ResponseModelDto>> Handle(UpdateOperationResponseCommand request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}