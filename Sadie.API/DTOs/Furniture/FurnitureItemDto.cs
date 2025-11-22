using System.ComponentModel;
using Sadie.API.DTOs.Catalog.Items;
using Sadie.Core.Enums.Game.Furniture;

namespace Sadie.API.DTOs.Furniture;

public class FurnitureItemDto
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public required string AssetName { get; init; }
    public FurnitureItemType Type { get; init; }
    public int AssetId { get; init; }
    public int TileSpanX { get; init; }
    public int TileSpanY { get; set; }
    public double StackHeight { get; init; }
    public bool CanStack { get; init; }
    public bool CanWalk { get; init; }
    public bool CanSit { get; init; }
    public bool CanLay { get; init; }
    public bool CanRecycle { get; init; } 
    public bool CanTrade { get; init; }
    public bool CanMarketplaceSell { get; init; }
    public bool CanInventoryStack { get; init; }
    public bool CanGift { get; init; }
    public required string? InteractionType { get; init; }
    public int InteractionModes { get; init; }
    public ICollection<CatalogItemDto> CatalogItems { get; init; } = [];
    public ICollection<HandItemDto> HandItems { get; init; } = [];
}