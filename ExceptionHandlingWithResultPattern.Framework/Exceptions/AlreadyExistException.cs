using System.Net;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions;

[Serializable]
public sealed class AlreadyExistException : CustomBaseException
{
    public override string MessageFormat =>  "{propName} : '{propValue}' ile bir {objectName} kaydı mevcut.";
    public override string Title => "Already Exist Error";
    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

   
    public AlreadyExistException(string propName, string propValue, string objectName): base()
    {
        MessageProps.Add("{propName}", propName);
        MessageProps.Add("{propValue}", propValue);
        MessageProps.Add("{objectName}", objectName);
    }
}
