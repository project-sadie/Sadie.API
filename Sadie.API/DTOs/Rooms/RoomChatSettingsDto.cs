namespace Sadie.API.DTOs.Rooms;

public record RoomChatSettingsDto
{
    public int Id { get; init; }
    public int RoomId { get; init; }
    public int ChatType { get; init; }
    public int ChatWeight { get; init; }
    public int ChatSpeed { get; init; }
    public int ChatDistance { get; init; }
    public int ChatProtection { get; init; }
}