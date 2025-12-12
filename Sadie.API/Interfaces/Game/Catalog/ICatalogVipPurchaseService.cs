using Sadie.API.Interfaces.Networking.Client;

namespace Sadie.API.Interfaces.Game.Catalog;

public interface ICatalogVipPurchaseService
{
    Task ProcessAsync(INetworkClient client, int itemId);
}