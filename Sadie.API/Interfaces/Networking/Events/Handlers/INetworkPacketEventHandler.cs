using Sadie.API.Interfaces.Networking.Client;

namespace Sadie.API.Interfaces.Networking.Events.Handlers;

public interface INetworkPacketEventHandler
{
    Task HandleAsync(INetworkClient client);
}