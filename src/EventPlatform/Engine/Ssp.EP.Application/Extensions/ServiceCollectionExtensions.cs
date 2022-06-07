using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ssp.EP.Application.Delivery;
using Ssp.EP.Application.Repositories;
using System.Diagnostics.CodeAnalysis;

namespace Ssp.EP.Application.Extensions;

[ExcludeFromCodeCoverage]
public static class ServiceCollectionExtensions
{
    public static void AddEventRouting(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IDeliveryStrategy, StandardStrategy>();
        services.AddTransient<IDeliveryStrategy, ImportantStrategy>();
        services.AddTransient<IEventConfigRepository, EventConfigRepository>();
    }
}