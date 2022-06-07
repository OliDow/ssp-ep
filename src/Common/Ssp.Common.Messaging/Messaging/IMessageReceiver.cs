namespace Ssp.Common.Messaging.Messaging;

public interface IMessageReceiver<TBusMessage>
{
    Task ReceiveAsync(TBusMessage busMessage, CancellationToken cancellationToken);
}