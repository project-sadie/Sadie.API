using System.Net;
using System.Net.WebSockets;
using Sadie.API.Interfaces.Networking;

namespace Sadie.API;

public interface INetworkObject
{
    Task WriteToStreamAsync(AbstractPacketWriter writer);
    Task WriteToStreamAsync(INetworkPacketWriter writer);
    List<INetworkPacketWriter> Outbox { get; set; }
    IPAddress IpAddress { get; set; } 
    Guid Guid { get; set; } 
    WebSocket WebSocket { get; set; } 
}