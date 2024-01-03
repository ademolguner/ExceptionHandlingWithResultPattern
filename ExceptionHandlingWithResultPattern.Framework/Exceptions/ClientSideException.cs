using System.Net;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions;

[Serializable]
public sealed class ClientSideException : CustomBaseException
{
    public override string MessageFormat => "Client : {clientName} - {processName} işlemi sırasında bir hata oluştu.";
    public override string Title => "Client Side Error";
    public override HttpStatusCode StatusCode => HttpStatusCode.InternalServerError;

    public ClientSideException(string clientName, string processName) : base()
    {
        MessageProps.Add("{clientName}", clientName);
        MessageProps.Add("{processName}", processName);
    }
}
