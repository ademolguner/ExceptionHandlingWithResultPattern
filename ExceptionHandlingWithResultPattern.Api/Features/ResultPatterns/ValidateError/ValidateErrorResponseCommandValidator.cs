using ExceptionHandlingWithResultPattern.Api.Common;
using FluentValidation;

namespace ExceptionHandlingWithResultPattern.Api.Features.ResultPatterns.ValidateError;

public class ValidateErrorResponseCommandValidator: AbstractValidator<ValidateErrorResponseCommand>
{
    public ValidateErrorResponseCommandValidator()
    {
        var nullOrEmptyMsg = ValidationConsts.NullOrEmpty_Validation;
        var guidRegexMsg = ValidationConsts.GuidRegex_Validation;

        
        RuleFor(x => x.UserId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage(nullOrEmptyMsg.Replace(ValidationConsts.FieldName, nameof(ValidateErrorResponseCommand.UserId)));
        
        RuleFor(x => x.UserId)
            .Cascade(CascadeMode.Stop)
            .Matches(ValidationConsts.GuidRegex)
            .WithMessage(guidRegexMsg.Replace(ValidationConsts.FieldName, nameof(ValidateErrorResponseCommand.UserId)));
        
        RuleFor(x => x.Name)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage(nullOrEmptyMsg.Replace(ValidationConsts.FieldName, nameof(ValidateErrorResponseCommand.Name)));

    }
}