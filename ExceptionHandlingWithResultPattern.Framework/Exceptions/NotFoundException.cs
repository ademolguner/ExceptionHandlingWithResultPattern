using System.Net;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions;

[Serializable]
public sealed class NotFoundException : CustomBaseException
{
    public override string MessageFormat => "Kayıt bulunamadı. {objectName}: '{objectValue}'";
    public override string Title => "Not Found Error";
    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public NotFoundException(string objectName, string objectValue) : base()
    {
        MessageProps.Add("{objectName}", objectName);
        MessageProps.Add("{objectValue}", objectValue);
    }
}
