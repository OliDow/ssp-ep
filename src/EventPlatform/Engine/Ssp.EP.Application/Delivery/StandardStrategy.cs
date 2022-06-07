using Ssp.Common.Messaging.EventHub;
using Ssp.EP.Events.Enums;

namespace Ssp.EP.Application.Delivery;

public class StandardStrategy : IDeliveryStrategy
{
    public EventDestination StrategyName { get; set; } = EventDestination.Standard;
    private readonly IEventHubClient _eventHubClient;

    public StandardStrategy(IEventHubClient eventHubClient)
    {
        _eventHubClient = eventHubClient ?? throw new ArgumentNullException(nameof(eventHubClient));
    }

    public Task PublishAsync(List<DeliveryEvent> dataEvents)
    {
        // _eventHubClient.Publish()
        throw new NotImplementedException();
    }
}