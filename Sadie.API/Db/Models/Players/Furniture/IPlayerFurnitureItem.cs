using Sadie.API.Db.Models.Furniture;

namespace Sadie.API.Db.Models.Players.Furniture;

public interface IPlayerFurnitureItem
{
    int Id { get; init; }
    long PlayerId { get; init; }
    IPlayer Player { get; init; }
    IFurnitureItem FurnitureItem { get; init; }
    IPlayerFurnitureItemPlacementData? PlacementData { get; init; }
    string LimitedData { get; init; }
    string MetaData { get; init; }
    DateTimeOffset CreatedAt { get; init; }
}