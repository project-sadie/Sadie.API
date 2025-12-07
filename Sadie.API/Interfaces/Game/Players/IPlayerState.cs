using Sadie.API.DTOs.Players.Furniture;

namespace Sadie.API.Interfaces.Game.Players;

public interface IPlayerState
{
    DateTime LastPlayerSearch { get; set; }
    DateTime LastDirectMessage { get; set; }
    DateTime LastCatalogPurchase { get; set; }
    DateTime LastSubscriptionModification { get; set; }
    string CatalogMode { get; set; }
    PlayerFurnitureItemPlacementDataDto? Teleport { get; set; }
    int CurrentRoomId { get; set; }
}