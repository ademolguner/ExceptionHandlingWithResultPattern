using ExceptionHandlingWithResultPattern.Framework.Exceptions.Validation;
using FluentValidation;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api.Behaviors;

public class ValidationBehavior<TRequest, TResponse>(IEnumerable<IValidator<TRequest>> validators) 
             : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    public Task<TResponse> Handle(TRequest request, 
                                  RequestHandlerDelegate<TResponse> next, 
                                  CancellationToken cancellationToken)
    {
        var context = new ValidationContext<TRequest>(request);
        var failures = validators
            .Select(x => x.Validate(context))
            .SelectMany(x => x.Errors)
            .Where(x => x != null)
            .ToList();

        if (failures.Count == 0)
            return next();

        throw new ArgumentValidationException(failures.Select(failure => failure.ErrorMessage).ToList());
    }
}