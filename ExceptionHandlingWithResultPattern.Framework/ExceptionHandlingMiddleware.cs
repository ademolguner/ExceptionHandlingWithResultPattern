using System.Net;
using System.Net.Mime;
using System.Text.Json;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Validation;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExceptionHandlingWithResultPattern.Framework;

public class ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
{
    private const string UnexpectedErrorMessage = "Beklenmeyen bir hata ile karşılaşıldı.";

    public async Task InvokeAsync(HttpContext context)
    {
        context.Response.ContentType = "application/json";
        
        try
        {
            await next(context);
        }
        catch (Exception exception)
        {
            var messages = new List<string>();
            var statusCode = (int)HttpStatusCode.InternalServerError;
            var title = "Server error";
            
            if (exception is ArgumentValidationException validationExp)
            {
                statusCode = (int)validationExp.StatusCode;
                title = "Validation Error";
                messages.AddRange(validationExp.MessageProps);
                
            }
            
            else if (exception is CustomBaseException customBaseException)
            {
                statusCode = (int)customBaseException.StatusCode;
                title = customBaseException.Title;
                
                var responseExMessage = customBaseException.MessageFormat;
                foreach (var (key, value) in customBaseException.MessageProps)
                    responseExMessage = responseExMessage.Replace(key, value);
                
                messages.Add(responseExMessage);
            }
            else
            {
                messages.Add(UnexpectedErrorMessage);
            }

            var problemDetails = new ProblemDetails
            { 
                Status = statusCode,
                Title = title,
                Detail = string.Join(Environment.NewLine,messages.ToArray())
            };
            
            logger.LogError("Exception Detail {@Exception-Status} - {@Exception-Title} - {@Exception-Detail} - {@Context-Path}",
                problemDetails.Status,
                problemDetails.Title,
                problemDetails.Detail,
                context.Request.Path);
            
            var responseResult = JsonSerializer.Serialize(GenericResult<GenericResponse>.Fail(problemDetails));
            await context.Response.WriteAsync(responseResult);
        }
    }
}
            
 
