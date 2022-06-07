namespace Ssp.Common.Messaging.Provider;

public interface IEventProvider<T>
    where T : IEvent
{
    Type GetEventType(string type);
}