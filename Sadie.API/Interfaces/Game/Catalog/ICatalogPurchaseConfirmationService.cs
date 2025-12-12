using Sadie.API.DTOs.Catalog.Items;
using Sadie.API.Interfaces.Networking.Client;

namespace Sadie.API.Interfaces.Game.Catalog;

public interface ICatalogPurchaseConfirmationService
{
    Task ConfirmAsync(INetworkClient client, CatalogItemDto item, int amount);
    Task WriteFailureAsync(INetworkClient client);
    Task WriteUnavailableAsync(INetworkClient client);
}