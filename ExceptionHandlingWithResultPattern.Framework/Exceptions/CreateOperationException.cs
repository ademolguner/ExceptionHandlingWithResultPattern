using System.Net;
using System.Text.Json;
using ExceptionHandlingWithResultPattern.Framework.Exceptions.Base;

namespace ExceptionHandlingWithResultPattern.Framework.Exceptions;

[Serializable]
public sealed class CreateOperationException : CustomBaseException
{
    public override string MessageFormat => "$modelName$ nesnesi veritabanına eklenirken hata oluştu. Model : $modelValue$";
    public override string Title => "Create Operation Error";
    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public CreateOperationException(string modelName, object modelValue): base()
    {
        MessageProps.Add("$modelName$", modelName);
        MessageProps.Add("$modelValue$", JsonSerializer.Serialize(modelValue));
    }
}
