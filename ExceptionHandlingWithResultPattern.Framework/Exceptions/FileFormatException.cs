using System.Net;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions;

[Serializable]
public sealed class FileFormatException : CustomBaseException
{
    public override string MessageFormat => "{extension} dosyası doğru formatta değil.";
    public override string Title => "File Format Error";
    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public FileFormatException(string extension) : base()
    {
        MessageProps.Add("{extension}", extension);
    }
}
