using Azure.Messaging.ServiceBus;

namespace Ssp.Common.Messaging.Messaging;

public interface IMessageReceiver
{
    Task ReceiveAsync(ServiceBusReceivedMessage busMessage, CancellationToken cancellationToken);
}