using Sadie.API.Interfaces.Networking.Client;

namespace Sadie.API.Interfaces.Game.Catalog;

public interface IVipPurchaseProcessor
{
    Task ProcessVipPurchaseAsync(INetworkClient client, int itemId);
}