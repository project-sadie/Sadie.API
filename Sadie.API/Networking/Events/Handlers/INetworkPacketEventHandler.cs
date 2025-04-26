using Sadie.API.Networking.Client;

namespace Sadie.API.Networking.Events.Handlers;

public interface INetworkPacketEventHandler
{
    Task HandleAsync(INetworkClient client);
}