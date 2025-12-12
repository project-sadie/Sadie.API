using Sadie.API.DTOs.Catalog.Items;
using Sadie.API.Interfaces.Networking.Client;

namespace Sadie.API.Interfaces.Game.Catalog;

public interface ICatalogBotPurchaseService
{
    Task ProcessAsync(INetworkClient client, CatalogItemDto item);
}