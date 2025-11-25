using Sadie.Core.Shared.Attributes;

namespace Sadie.API.DTOs.Rooms;

public record RoomCategoryDto
{
    [PacketData] public int Id { get; init; }
    [PacketData] public string? Caption { get; init; }
    [PacketData] public bool IsVisible { get; init; }
}