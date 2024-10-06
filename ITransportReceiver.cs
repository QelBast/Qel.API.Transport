namespace Qel.Api.Transport.Generic;

public interface ITransportReceiver<T>
{
    public void Receive(IMessageProcesser<T> processer);
}
