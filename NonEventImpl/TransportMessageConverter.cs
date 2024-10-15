using System.Text;

namespace Qel.Api.Transport;

public static class TransportMessageConverter
{
    public static string GetUTF8String(byte[] body) => Encoding.UTF8.GetString(body);
}
