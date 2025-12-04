using System.Net.WebSockets;

namespace Sadie.API.Interfaces.Networking;

public interface IWebSocketMessageReader
{
    Task<byte[]> ReadMessageAsync(WebSocket socket, CancellationToken token);
}