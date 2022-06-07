using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Ssp.Common.Extensions;
using Ssp.Common.Messaging.Extensions;
using Ssp.EP.Application.Extensions;
using Ssp.EP.Events.Source;
using Ssp.EP.FunctionApp;
using System.Reflection;

#pragma warning disable CS8603

[assembly: FunctionsStartup(typeof(Startup))]

namespace Ssp.EP.FunctionApp;

public class Startup : FunctionsStartup
{
    private static string ExecutingAssemblyName => Assembly.GetExecutingAssembly().GetName().Name;

    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddTelemetry(ExecutingAssemblyName);
        builder.Services.AddCommonProviders();

        var configuration = builder.GetContext().Configuration;
        builder.Services.AddPocMessaging(configuration);
        builder.Services.AddPocEventHub(configuration);
        builder.Services.AddEventProvider<MeterCreated>();
        builder.Services.AddEventRouting(configuration);
    }
}