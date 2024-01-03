using System.Net;
using System.Text.Json;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions;

[Serializable]
public sealed class DeleteOperationException : CustomBaseException
{
    public override string MessageFormat => "{modelName} nesnesi veritabanından silinirken hata oluştu. Model : {modelValue}";
    public override string Title => "Delete Operation Error";
    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public DeleteOperationException(string modelName, object modelValue) : base()
    {
        MessageProps.Add("{modelName}", modelName);
        MessageProps.Add("{modelValue}", JsonSerializer.Serialize(modelValue));
    }
}