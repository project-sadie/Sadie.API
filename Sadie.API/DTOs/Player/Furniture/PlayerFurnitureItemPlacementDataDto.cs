namespace Sadie.API.DTOs.Player.Furniture;

public record PlayerFurnitureItemPlacementDataDto
{
    public int RoomId { get; init; }
    public int PositionX { get; init; }
    public int PositionY { get; init; }
    public double PositionZ { get; init; }
    public string? WallPosition { get; init; }
    public int Direction { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public PlayerFurnitureItemWiredDataDto? WiredData { get; init; }
}