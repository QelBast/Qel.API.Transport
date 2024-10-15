namespace Qel.Api.Transport.EventBus;

public interface IEventBus
{
    Task Publish(IntegrationEvent @event);
}