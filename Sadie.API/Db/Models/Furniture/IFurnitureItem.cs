using Sadie.API.Db.Models.Catalog.Items;
using Sadie.Enums.Game.Furniture;

namespace Sadie.API.Db.Models.Furniture;

public interface IFurnitureItem
{
    int Id { get; init; }
    string Name { get; init; }
    string AssetName { get; init; }
    FurnitureItemType Type { get; init; }
    int AssetId { get; init; }
    int TileSpanX { get; init; }
    int TileSpanY { get; set; }
    double StackHeight { get; init; }
    bool CanStack { get; init; }
    bool CanWalk { get; init; }
    bool CanSit { get; init; }
    bool CanLay { get; init; }
    bool CanRecycle { get; init; }
    bool CanTrade { get; init; }
    bool CanMarketplaceSell { get; init; }
    bool CanInventoryStack { get; init; }
    bool CanGift { get; init; }
    string? InteractionType { get; init; }
    int InteractionModes { get; init; }
    ICollection<ICatalogItem> CatalogItems { get; init; }
    ICollection<IHandItem> HandItems { get; init; }
}