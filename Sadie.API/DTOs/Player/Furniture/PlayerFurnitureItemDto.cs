using Sadie.API.DTOs.Furniture;

namespace Sadie.API.DTOs.Player.Furniture;

public record PlayerFurnitureItemDto
{
    public int Id { get; init; }
    public long PlayerId { get; set; }
    public required FurnitureItemDto FurnitureItem { get; init; }
    public PlayerFurnitureItemPlacementDataDto? PlacementData { get; set; }
    public required string LimitedData { get; init; }
    public required string MetaData { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
}