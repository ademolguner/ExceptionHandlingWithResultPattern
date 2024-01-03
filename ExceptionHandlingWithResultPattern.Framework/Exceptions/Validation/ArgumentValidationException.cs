using System.Net;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions.Validation;

[Serializable]
public class ArgumentValidationException : Exception
{
    public HttpStatusCode StatusCode => HttpStatusCode.BadRequest;
    public List<string> MessageProps { get; } = new();
    
    public ArgumentValidationException(List<string> errors) : base()
    {
        MessageProps.AddRange(errors);
    }
}
