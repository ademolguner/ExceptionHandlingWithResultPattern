using System.Net;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandlingWithResultPattern.Framework.ResultPattern;

public class GenericResult<T> where T: class, new()
{
    private GenericResult() : this(true)
    { }

    private GenericResult(bool isSuccess)
    { IsSuccess = isSuccess; if (!isSuccess) {Data = null;} }

    
    [JsonPropertyName("IsSuccess")] public bool IsSuccess { get; init; }
    [JsonPropertyName("Data")] public T Data { get; private init; } = new();
    [JsonPropertyName("ProblemDetails")] public ProblemDetails ProblemDetails { get; private init; } = new();
  
    
    public static GenericResult<T> Success(T data)
    {
        return new GenericResult<T>(true)
        {
            Data = data
        };
    }

    public static GenericResult<T> Fail(string message)
    {
        return new GenericResult<T>(false)
        {
            ProblemDetails = new ProblemDetails
            {
                Status = (int) HttpStatusCode.BadRequest,
                Title = "Operation Error",
                Detail = message
            }
        };
    }
    
    public static GenericResult<T> Exception(ProblemDetails problemDetails)
    {
        return new GenericResult<T>(false)
        {
            ProblemDetails = problemDetails
        };
    }
}