using Sadie.API.Db.Models.Furniture;
using Sadie.API.Db.Models.Players;
using Sadie.API.Db.Models.Players.Furniture;

namespace Sadie.API.Game.Players;

public interface IPlayerFurnitureItem
{
    int Id { get; init; }
    int PlayerId { get; set; }
    IPlayer Player { get; set; }
    IFurnitureItem FurnitureItem { get; init; }
    IPlayerFurnitureItemPlacementData? PlacementData { get; set; }
    string LimitedData { get; init; }
    string MetaData { get; set; }
    DateTime CreatedAt { get; init; }
}