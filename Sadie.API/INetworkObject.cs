using DotNetty.Transport.Channels;
using Sadie.API.Interfaces.Networking;

namespace Sadie.API;

public interface INetworkObject
{
    Task WriteToStreamAsync(AbstractPacketWriter writer);
    Task WriteToStreamAsync(INetworkPacketWriter writer);
    Task WriteBatchToStreamAsync(List<INetworkPacketWriter> writers);
    List<INetworkPacketWriter> Outbox { get; set; }
    IChannel Channel { get; set; } 
}