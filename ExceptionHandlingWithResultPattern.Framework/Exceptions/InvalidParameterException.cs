using System.Net;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions;

[Serializable]
public sealed class InvalidParameterException : CustomBaseException
{
    public override string MessageFormat => "Geçersiz parametre. {fieldName} : {fieldValue}";
    public override string Title => "Invalid Parameter Error";
    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public InvalidParameterException(string fieldName, string fieldValue) : base()
    {
        MessageProps.Add("{fieldName}", fieldName);
        MessageProps.Add("{fieldValue}", fieldValue);
    }
}
