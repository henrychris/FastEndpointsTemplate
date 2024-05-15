using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FastEndpointsTemplate.Configuration;

public static class ServiceConfiguration
{
    /// <summary>
    /// Register services in the DI container.
    /// </summary>
    /// <param name="services"></param>
    public static void RegisterServices(this IServiceCollection services)
    {
        // services.AddScoped<ICurrentUser, CurrentUser>();
        // used for time manipulation and testing
        // we should use this instead of DateTime.Now
        services.AddSingleton(TimeProvider.System);
        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    }
}