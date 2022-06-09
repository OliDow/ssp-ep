using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;
using System.Diagnostics.CodeAnalysis;

namespace Ssp.Common.Telemetry
{
    [ExcludeFromCodeCoverage]
    public class CloudRoleNameInitializer : ITelemetryInitializer
    {
        private readonly string _cloudRoleName;

        public CloudRoleNameInitializer(string cloudRoleName)
        {
            _cloudRoleName = cloudRoleName;
        }

        public void Initialize(ITelemetry telemetry)
        {
            telemetry.Context.Cloud.RoleName = _cloudRoleName;
        }
    }
}