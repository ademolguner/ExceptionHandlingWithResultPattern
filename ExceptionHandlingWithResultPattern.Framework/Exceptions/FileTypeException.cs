using System.Net;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions;

[Serializable]
public sealed class FileTypeException : CustomBaseException
{
    public override string MessageFormat => "Bu işlem için {extension} uzantılı dosya kullanılamaz.";
    public override string Title => "File Type Error";
    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public FileTypeException(string extension) : base()
    {
        MessageProps.Add("{extension}", extension);
    }
}
