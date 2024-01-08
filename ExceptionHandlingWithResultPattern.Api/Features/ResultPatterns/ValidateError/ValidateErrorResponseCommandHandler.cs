using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.ValidateError;

public class ValidateErrorResponseCommandHandler:IRequestHandler<ValidateErrorResponseCommand,GenericResult<ResponseModelDto>>
{
    public Task<GenericResult<ResponseModelDto>> Handle(ValidateErrorResponseCommand request, CancellationToken cancellationToken)
    {
        var dto = new ResponseModelDto(request.UserId, request.Name);
        return Task.FromResult(GenericResult<ResponseModelDto>.Success(dto));
    }
}