using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandlingWithResultPattern.Framework.ResultPattern;

public class GenericResult<T> where T: class, new()
{
    private GenericResult() : this(true)
    {
    }

    private GenericResult(bool isSuccess)
    {
        IsSuccess = isSuccess;
    }

    public bool IsSuccess { get; init; }
    public T Data { get; private init; } = new();
    public ProblemDetails ProblemDetails { get; private init; } = new();
  

    
    public static GenericResult<T> Success(T data)
    {
        return new GenericResult<T>(true)
        {
            Data = data, 
            ProblemDetails = new ProblemDetails()
        };
    }
    
    public static GenericResult<T> Fail(string message)
    {
        return new GenericResult<T>(false)
        {
            ProblemDetails = new ProblemDetails
            {
                Status = (int)HttpStatusCode.BadRequest,
                Title = "Operation Error",
                Detail = message
            }
        };
    }
    
    public static GenericResult<T> Fail(ProblemDetails problemDetails)
    {
        return new GenericResult<T>(false)
        {
            ProblemDetails = problemDetails
        };
    }
}