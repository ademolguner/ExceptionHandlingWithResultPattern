using System.Net;
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
            
            switch (exception)
            {
                case ArgumentValidationException validationExp:
                    statusCode = (int)ArgumentValidationException.StatusCode;
                    title = "Validation Error";
                    messages.AddRange(validationExp.MessageProps);
                    break;
                case CustomBaseException customBaseException:
                {
                    statusCode = (int)customBaseException.StatusCode;
                    title = customBaseException.Title;
                
                    var responseExMessage = customBaseException.MessageFormat;
                    foreach (var (key, value) in customBaseException.MessageProps)
                        responseExMessage = responseExMessage.Replace(key, value);
                
                    messages.Add(responseExMessage);
                    break;
                }
                default:
                    messages.Add(UnexpectedErrorMessage);
                    break;
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
                context.Request.Path.Value);
            
            var responseResult = JsonSerializer.Serialize(GenericResult<GenericResponse>.Exception(problemDetails));
            await context.Response.WriteAsync(responseResult);
        }
    }
}
            
 
