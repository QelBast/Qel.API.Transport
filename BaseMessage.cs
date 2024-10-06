namespace Qel.Api.Transport;

public class BaseMessage<T>(string? content)
{
    public string? Content { get; set; } = content;
}
