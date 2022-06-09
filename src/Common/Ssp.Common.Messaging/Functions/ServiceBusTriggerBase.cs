using Azure.Messaging.ServiceBus;
using Microsoft.Azure.WebJobs.ServiceBus;
using Ssp.Common.Messaging.Functions.Builders;
using Ssp.Common.Messaging.Messaging;
using Ssp.Common.Messaging.Repository;

namespace Ssp.Common.Messaging.Functions;

public abstract class ServiceBusTriggerBase : TriggerBase
{
    private readonly IErrorMetadataBuilder _errorMetadataBuilder;
    private readonly IMessageReceiver _messageReceiver;

    protected ServiceBusTriggerBase(
        IMessageContext messageContext,
        IErrorMetadataBuilder errorMetadataBuilder,
        IMessageReceiver messageReceiver,
        IEventSchemaRepository eventSchemaRepository)
        : base(messageContext, eventSchemaRepository)
    {
        _errorMetadataBuilder = errorMetadataBuilder ?? throw new ArgumentNullException(nameof(errorMetadataBuilder));
        _messageReceiver = messageReceiver;
    }

    protected async Task ProcessMessageAsync(
        ServiceBusReceivedMessage message, ServiceBusMessageActions messageActions, CancellationToken cancellationToken)
    {
        try
        {
            await _messageReceiver.ReceiveAsync(message, cancellationToken);
            await messageActions.CompleteMessageAsync(message, cancellationToken);
        }
        catch (Exception ex)
        {
            // Override the AbandonMessage to enrich message with exception data
            var propertiesToModify = _errorMetadataBuilder.BuildErrorMetadata(message.DeliveryCount, ex);
            await messageActions.AbandonMessageAsync(message, propertiesToModify, cancellationToken);
            throw;
        }
    }
}