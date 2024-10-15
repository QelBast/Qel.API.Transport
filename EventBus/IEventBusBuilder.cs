using Microsoft.Extensions.DependencyInjection;

namespace Qel.Api.Transport.EventBus;

public interface IEventBusBuilder
{
    public IServiceCollection Services { get; }
}