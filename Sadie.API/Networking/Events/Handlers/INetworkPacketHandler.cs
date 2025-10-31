using Sadie.API.Networking.Client;

namespace Sadie.API.Networking.Events.Handlers;

public interface INetworkPacketHandler
{
    Task HandleAsync(INetworkClient client);
}