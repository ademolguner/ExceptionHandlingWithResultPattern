using System.Net;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions.Validation;

[Serializable]
public sealed class ArgumentValidationException : Exception
{
    public static HttpStatusCode StatusCode => HttpStatusCode.BadRequest;
    public List<string> MessageProps { get; } = new();
    
    public ArgumentValidationException(List<string> errors) : base()
    {
        MessageProps.AddRange(errors);
    }
}
