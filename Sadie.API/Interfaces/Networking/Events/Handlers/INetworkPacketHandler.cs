using Sadie.API.Interfaces.Networking.Client;

namespace Sadie.API.Interfaces.Networking.Events.Handlers;

public interface INetworkPacketHandler
{
    Task HandleAsync(INetworkClient client);
}