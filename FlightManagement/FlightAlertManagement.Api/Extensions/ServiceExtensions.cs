using FlightAlertManagement.DAL;
using FlightAlertManagement.Services;

namespace FlightAlertManagement.Api.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Register your repositories, services, etc.
        services.AddSingleton<IAlertRepository, InMemoryAlertRepository>(); 
        services.AddScoped<IAlertService, AlertService>();

        return services;
    }
}