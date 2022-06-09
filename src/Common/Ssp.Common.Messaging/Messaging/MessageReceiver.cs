using Azure.Messaging.ServiceBus;
using MediatR;
using System.Text.Json;

namespace Ssp.Common.Messaging.Messaging;

public class MessageReceiver : IMessageReceiver
{
    private readonly IMediator _mediator;

    public MessageReceiver(IMediator mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    public Task ReceiveAsync(ServiceBusReceivedMessage busMessage, CancellationToken cancellationToken)
    {
        var messageTypeProp = busMessage.ApplicationProperties.GetValueOrDefault(Constants.MessageTypePropertyName);
        var messageType = Type.GetType(messageTypeProp?.ToString() ?? string.Empty, true);
        var payloadJson = busMessage.Body.ToString();
        var payload = JsonSerializer.Deserialize(payloadJson, messageType!);

        return _mediator.Send(payload!, cancellationToken);
    }
}