using Sadie.Core.Enums.Miscellaneous;

namespace Sadie.API.DTOs.Player.Furniture;

public record PlayerFurnitureItemPlacementDataDto
{
    public int Id { get; init; }
    public int PlayerFurnitureItemId { get; init; }
    public required PlayerFurnitureItemDto PlayerFurnitureItem { get; init; }
    public int RoomId { get; init; }
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public double PositionZ { get; set; }
    public string? WallPosition { get; init; }
    public HDirection Direction { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public PlayerFurnitureItemWiredDataDto? WiredData { get; init; }
}