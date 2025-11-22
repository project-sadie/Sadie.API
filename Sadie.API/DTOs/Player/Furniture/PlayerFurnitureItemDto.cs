namespace Sadie.API.DTOs.Player.Furniture;

public record PlayerFurnitureItemDto
{
    public int Id { get; init; }
    public long PlayerId { get; set; }
    public required PlayerDto Player { get; set; }
    public int FurnitureItemId { get; init; }
    public string LimitedData { get; init; } = string.Empty;
    public string MetaData { get; init; } = string.Empty;
    public PlayerFurnitureItemPlacementDataDto? PlacementData { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
}