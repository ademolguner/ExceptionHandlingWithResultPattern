using ExceptionHandlingWithResultPattern.Api.Data;
using ExceptionHandlingWithResultPattern.Api.Models.Responses;
using ExceptionHandlingWithResultPattern.Framework.Exceptions;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.Fail;

public class FailResponseQueryHandler:IRequestHandler<FailResponseQuery,GenericResult<ResponseModelDto>>
{
    public async Task<GenericResult<ResponseModelDto>> Handle(FailResponseQuery request, CancellationToken cancellationToken)
    {
        var mockDataModels = MockDataModel.GetDatabaseExampleModels();

        var mockItem = mockDataModels.FirstOrDefault(c => c.UserId.Equals(request.UserId));
        if (mockItem is null)
            throw new NotFoundException(nameof(MockDataModel), nameof(MockDataModel.UserId),request.UserId);

        if (mockItem.Name != request.Name)
            return GenericResult<ResponseModelDto>.Fail($"Girdiğiniz UserId : {request.Name} alanı ile modele ait UserId : {mockItem.Name} alanı eşleşmiyor.");
          
        return GenericResult<ResponseModelDto>.Success(new ResponseModelDto{UserId = request.UserId, Name = request.Name});
    }
}