using System.Net;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

[Serializable]
public abstract class CustomBaseException : Exception
{
    public virtual string MessageFormat { get;}
    public virtual string Title  { get; }
    public virtual HttpStatusCode StatusCode  { get; }
    public virtual Dictionary<string, string> MessageProps { get; set; } = new();
}