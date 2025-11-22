namespace Sadie.API.DTOs.Rooms;

public record RoomCategoryDto
{
    public int Id { get; init; }
    public string? Caption { get; init; }
    public bool IsVisible { get; init; }
}