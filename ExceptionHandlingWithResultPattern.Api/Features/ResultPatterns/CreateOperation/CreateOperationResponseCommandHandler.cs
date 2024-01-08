using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.CreateOperation;

public class CreateOperationResponseCommandHandler:IRequestHandler<CreateOperationResponseCommand,GenericResult<ResponseModelDto>>
{
    public Task<GenericResult<ResponseModelDto>> Handle(CreateOperationResponseCommand request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}