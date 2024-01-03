using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ExceptionHandlingWithResultPattern.Api.Data;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.Exceptions;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Already;

public class AlreadyResponseCommandHandler:IRequestHandler<AlreadyResponseCommand,ResponseModelDto>
{
    public Task<ResponseModelDto> Handle(AlreadyResponseCommand command, CancellationToken cancellationToken)
    {
        var mockDataModels = MockDataModel.GetDatabaseExampleModels();
        if (mockDataModels.Any(c => c.Name == command.Name))
            throw new AlreadyExistException(nameof(AlreadyResponseCommand.Name), command.Name, nameof(MockDataModel));
        return Task.FromResult(new ResponseModelDto());
    }
}