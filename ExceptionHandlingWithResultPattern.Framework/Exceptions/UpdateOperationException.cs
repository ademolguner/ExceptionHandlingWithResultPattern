using System.Net;
using System.Text.Json;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions;

[Serializable]
public sealed class UpdateOperationException : CustomBaseException
{
    public override string MessageFormat => "{modelName} nesnesi veritabanında güncellenirken hata oluştu. Model : {modelValue}";
    public override string Title => "Update Operation Error";
    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public UpdateOperationException(string modelName, object modelValue) : base()
    {
        MessageProps.Add("{modelName}", modelName);
        MessageProps.Add("{modelValue}", JsonSerializer.Serialize(modelValue));
    }
}
