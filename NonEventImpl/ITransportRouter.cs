namespace Qel.Api.Transport;

public interface ITransportRouter
{
    public Task AllRouteWithOneConnection(CancellationToken token);

    public Task AllRouteWithDifferentConnection(CancellationToken token);

    public Task OnlyReceiveRoute(CancellationToken token);
}
