using Ssp.EP.Events.Enums;

namespace Ssp.EP.Application.Delivery;

public record DeliveryEvent(object Payload, List<EventContext> Context);