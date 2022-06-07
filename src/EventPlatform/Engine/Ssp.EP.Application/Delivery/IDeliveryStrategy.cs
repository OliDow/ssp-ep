using Ssp.EP.Events.Enums;

namespace Ssp.EP.Application.Delivery;

public interface IDeliveryStrategy
{
    public EventDestination StrategyName { get; set; }
    Task PublishAsync(List<DeliveryEvent> dataEvents);
}