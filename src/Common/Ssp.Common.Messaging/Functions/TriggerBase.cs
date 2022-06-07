using Ssp.Common.Messaging.Messaging;
using Ssp.Common.Messaging.Repository;

// ReSharper disable InvokeAsExtensionMethod
namespace Ssp.Common.Messaging.Functions;

public abstract class TriggerBase
{
    protected IMessageContext MessageContext { get; }
    protected IEventSchemaRepository EventSchemaRepository { get; }

    protected TriggerBase(IMessageContext messageContext, IEventSchemaRepository eventSchemaRepository)
    {
        MessageContext = messageContext ?? throw new ArgumentNullException(nameof(messageContext));
        EventSchemaRepository = eventSchemaRepository ?? throw new ArgumentNullException(nameof(eventSchemaRepository));
    }
}