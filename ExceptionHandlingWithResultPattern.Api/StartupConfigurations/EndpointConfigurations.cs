using ExceptionHandlingWithResultPattern.Api.EndPoints;

namespace ExceptionHandlingWithResultPattern.Api.StartupConfigurations;

public static class EndpointConfigurations
{
    public static IEndpointRouteBuilder RegistrationEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapControllers();
        app.MapExceptionEndpoints();
        return app;
    }
}