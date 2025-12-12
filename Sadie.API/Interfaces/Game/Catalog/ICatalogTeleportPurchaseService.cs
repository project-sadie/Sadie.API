using Sadie.API.DTOs.Catalog.Items;
using Sadie.API.Interfaces.Networking.Client;

namespace Sadie.API.Interfaces.Game.Catalog;

public interface ICatalogTeleportPurchaseService
{
    Task ProcessAsync(INetworkClient client, CatalogItemDto item, string? metaData, int amount);
}