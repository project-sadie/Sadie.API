using Sadie.API.DTOs.Player;
using Sadie.API.DTOs.Player.Furniture;
using Sadie.API.DTOs.Rooms.Chat;
using Sadie.API.DTOs.Rooms.Rights;

namespace Sadie.API.DTOs.Rooms;

public record RoomDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int LayoutId { get; set; }
    public RoomLayoutDto? Layout { get; set; }
    public long OwnerId { get; set; }
    public int MaxUsersAllowed { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsMuted { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
    public RoomSettingsDto? Settings { get; set; }
    public RoomPaintSettingsDto? PaintSettings { get; set; }
    public RoomChatSettingsDto? ChatSettings { get; set; }
    public ICollection<RoomPlayerRightDto> PlayerRights { get; init; } = [];
    public ICollection<RoomChatMessageDto> ChatMessages { get; init; } = [];
    public ICollection<RoomTagDto> Tags { get; init; } = [];
    public ICollection<PlayerRoomLikeDto> PlayerLikes { get; init; } = [];
    public ICollection<PlayerFurnitureItemPlacementDataDto> FurnitureItems { get; init; } = [];
    public GroupDto? Group { get; init; }
    public RoomDimmerSettingsDto? DimmerSettings { get; set; }
    public ICollection<PlayerBanDto> PlayerBans { get; set; } = [];
}