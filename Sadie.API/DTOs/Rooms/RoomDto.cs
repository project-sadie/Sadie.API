namespace Sadie.API.DTOs.Rooms;

public record RoomDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int LayoutId { get; set; }
    public long OwnerId { get; set; }
    public int MaxUsersAllowed { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsMuted { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public RoomSettingsDto? Settings { get; set; }
    public RoomPaintSettingsDto? PaintSettings { get; set; }
    public RoomChatSettingsDto? ChatSettings { get; set; }
    public RoomDimmerSettingsDto? DimmerSettings { get; set; }
    public GroupDto? Group { get; set; }
}