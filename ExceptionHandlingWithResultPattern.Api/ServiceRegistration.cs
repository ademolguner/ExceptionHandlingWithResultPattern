using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExceptionHandlingWithResultPattern.Api;

public static class ServiceRegistration
{
    public static IServiceCollection RegistrationMediator(this IServiceCollection services)
    {
        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
        return services;
    }
    
    public static IServiceCollection RegisterClients(this IServiceCollection services,IConfiguration configuration)
    {
        return services.AddHttpClient();
    }
    
}