using Sadie.API.DTOs.Catalog.Items;
using Sadie.API.Interfaces.Networking.Client;

namespace Sadie.API.Interfaces.Game.Catalog;

public interface ICatalogChargeService
{
    bool HasRequiredMembership(INetworkClient client, CatalogItemDto item);
    Task<bool> TryChargeAsync(INetworkClient client, CatalogItemDto item, int amount);
}