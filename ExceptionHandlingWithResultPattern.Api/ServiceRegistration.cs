using System.Reflection;
using ExceptionHandlingWithResultPattern.Api.Behaviors;
using FluentValidation;
using MediatR;

namespace ExceptionHandlingWithResultPattern.Api;

public static class ServiceRegistration
{
    public static IServiceCollection RegistrationMediator(this IServiceCollection services)
    {
        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
        return services;
    }
    
    public static IServiceCollection RegistrationValidator(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
              .AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        return services;
    }
    
    public static IServiceCollection RegisterClients(this IServiceCollection services,IConfiguration configuration)
    {
        return services.AddHttpClient();
    }
}