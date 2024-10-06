namespace Qel.Api.Transport.Generic;

public interface ITransportSender
{
    public void Send<T>(BaseMessage<T> message);
}
