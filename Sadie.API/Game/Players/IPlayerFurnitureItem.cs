using Sadie.Db.Models.Furniture;
using Sadie.Db.Models.Players;
using Sadie.Db.Models.Players.Furniture;

namespace Sadie.API.Game.Players;

public interface IPlayerFurnitureItem
{
    int Id { get; init; }
    int PlayerId { get; set; }
    Player Player { get; set; }
    FurnitureItem FurnitureItem { get; init; }
    PlayerFurnitureItemPlacementData? PlacementData { get; set; }
    string LimitedData { get; init; }
    string MetaData { get; set; }
    DateTime CreatedAt { get; init; }
}