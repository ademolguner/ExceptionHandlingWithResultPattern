using System;
using ExceptionHandlingWithResultPattern.Framework.ResultPattern;

namespace ExceptionHandlingWithResultPattern.Api.Models.Responses;

public class ResponseModelDto:IGenericResponse
{
    public string Id { get; set; } = "1985";
    public string Uuid { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = "NoName";
}