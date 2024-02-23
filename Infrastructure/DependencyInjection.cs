using Application.Interfaces;
using Application.Interfaces.Repositories;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<INotificationService, NotificationService>();
        
        return services;
    }
}