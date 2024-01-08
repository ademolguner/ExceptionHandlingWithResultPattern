using System.Net;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions;

[Serializable]
public sealed class NotFoundException : CustomBaseException
{
    public override string MessageFormat => "{objectName} Kayıt bulunamadı. {propertyName}: '{propertyValue}'";
    public override string Title => "Not Found Error";
    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public NotFoundException(string objectName, string propertyName, string propertyValue) : base()
    {
        MessageProps.Add("{objectName}", objectName);
        MessageProps.Add("{propertyName}", propertyName);
        MessageProps.Add("{propertyValue}", propertyValue);
    }
}
