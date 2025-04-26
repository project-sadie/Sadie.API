using Sadie.API.Networking.Client;

namespace Sadie.API.Networking.Packets;

public interface INetworkPacketHandler
{ 
    Task HandleAsync(INetworkClient client, INetworkPacket packet);
}