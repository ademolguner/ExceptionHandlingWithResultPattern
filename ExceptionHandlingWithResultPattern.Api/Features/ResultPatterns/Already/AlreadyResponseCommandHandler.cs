using ExceptionHandlingWithResultPattern.Api.Data;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.Exceptions;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Already;

public class AlreadyResponseCommandHandler:IRequestHandler<AlreadyResponseCommand,GenericResult<ResponseModelDto>>
{
    public async Task<GenericResult<ResponseModelDto>> Handle(AlreadyResponseCommand command, CancellationToken cancellationToken)
    {
        var mockDataModels = MockDataModel.GetDatabaseExampleModels();
        if (mockDataModels.Any(c => c.Name == command.Name))
            throw new AlreadyExistException(nameof(AlreadyResponseCommand.Name), command.Name, nameof(MockDataModel));
 
        return GenericResult<ResponseModelDto>.Success(new ResponseModelDto{UserId = command.UserId, Name = command.Name});
    }
}