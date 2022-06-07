using Microsoft.Extensions.Configuration;
using Ssp.Common.Messaging.Messaging;

namespace Ssp.Common.Messaging.EventHub;

public class EventEventHubClient : IEventHubClient
{
    public EventEventHubClient(IMessageContext messageContext, IConfiguration configuration) { }
}