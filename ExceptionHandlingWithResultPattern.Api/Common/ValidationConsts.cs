namespace ExceptionHandlingWithResultPattern.Api.Common;

public static class ValidationConsts
{
    public const string ObjectIdRegex = @"^\s*([0-9a-z]{24})\z";
    public const string GuidRegex = @"^([0-9A-Fa-f]{8}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{12})$";
    public const string PhoneRegex = @"^((\d{3})(\d{3})(\d{2})(\d{2}))$";
    
    public const string NullOrEmpty_Validation = "'$fieldName$' alanı boş olamaz.";
    public const string IsInEnum_Validation = "'$fieldName$' yalnızca $fieldValue$ değerlerini alabilir.";
    public const string GreaterThan_Validation = "'$fieldName$' alanı $fieldValue$ değerinden büyük olmalıdır.";
    public const string ObjectRegex_Validation = "'$fieldName$' alanı alfanumerik karakterlerden oluşmalı ve 24 birim uzunluğunda olmalıdır. (örn. 6113cccefa6fc722075f8334).";
    public const string GreaterOrEqualThanDate_Validation = "'$fieldName$' alanı $fieldValue$ eşit yada büyük olmalıdır.";
    public const string XssContent_Validation = "'$fieldName$' için girilen değer güvenlik nedeniyle kabul edilemez.";
    public  const string EnumTypePhone_Validation ="'$fieldName$' sms olduğunda '$fieldName2$' alanı telefon numarası olmalıdır.";
    public  const string EnumTypeEmail_Validation = "'$fieldName$' email olduğunda '$fieldName2$' alanı email olmalıdır.";
    public  const string EnumTypeNotYetImplemented_Validation = "'$fieldName$' henüz tanımlanmadı.";
    public  const string GuidRegex_Validation = "$fieldName$' alanı GUID veri tipinde olmalı ve 36 birim uzunluğunda olmalıdır. (örn. bd956164-3d1b-4b4f-a592-1d0f066ec789).";  
    public  const string FileFormat_Validation = "Hatalı dosya formatı.";
    public  const string LessOrEqualThanDate_Validation = "'$fieldName$' alanı $fieldValue$ eşit veya küçük olmalıdır.";
    public  const string FieldRelatedValue_Validation = "'$fieldName$' $fieldValue$ olduğunda '$fieldName2$' alanı boş olmalıdır.";
    public const string Periodic_Frequeny_Validation = "'$fieldName$' alanı 30 ve 30'un katları olmalıdır. (30,60,90,120 vb...)";
    
  
    public const string FieldName = "$fieldName$";
    public const string FieldName2 = "$fieldName2$";
    public const string FieldValue = "$fieldValue$";
}
