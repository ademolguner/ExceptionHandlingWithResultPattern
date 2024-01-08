using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Success;

public class SuccessResponseCommandHandler:IRequestHandler<SuccessResponseCommand,GenericResult<ResponseModelDto>>
{
    public async Task<GenericResult<ResponseModelDto>> Handle(SuccessResponseCommand command, CancellationToken cancellationToken)
    {
        return GenericResult<ResponseModelDto>.Success(new ResponseModelDto(command.UserId,command.Name));
    }
}