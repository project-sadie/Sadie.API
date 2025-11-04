namespace Sadie.API.DTOs.Player.Furniture;

public class PlayerFurnitureItemDto
{
    public int FurnitureItemId { get; init; }
    public string LimitedData { get; init; } = string.Empty;
    public string MetaData { get; init; } = string.Empty;
    public PlayerFurnitureItemPlacementDataDto? PlacementData { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
}