using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Http;
using Ssp.Common.Messaging.Messaging;
using Ssp.Common.Messaging.Repository;
using Ssp.Common.Providers;

namespace Ssp.Common.Messaging.Functions;

public abstract class HttpTriggerBase : TriggerBase
{
    private readonly IGuidProvider _guidProvider;

    protected HttpTriggerBase(IMessageContext messageContext, IEventSchemaRepository eventSchemaRepository,
        IGuidProvider guidProvider)
        : base(messageContext, eventSchemaRepository)
    {
        _guidProvider = guidProvider ?? throw new ArgumentNullException(nameof(guidProvider));
    }

    protected void SetCorrelationFromHttpRequestHeader(HttpRequest httpRequest)
    {
        var requestTelemetry = httpRequest.HttpContext.Features.Get<RequestTelemetry>();
        if (!httpRequest.Headers.TryGetValue("x-correlation-id", out var correlationId))
        {
            correlationId = _guidProvider.NewGuid().ToString();
        }

        requestTelemetry.Context.Operation.Id = correlationId;
        MessageContext.CorrelationId = correlationId;
    }
}