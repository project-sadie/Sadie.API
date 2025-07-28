using Sadie.Db.Models.Players;
using Sadie.Db.Models.Players.Furniture;
using Sadie.Db.Models.Rooms;
using Sadie.Db.Models.Rooms.Chat;
using Sadie.Db.Models.Rooms.Rights;
using Group = Sadie.Db.Models.Group;

namespace Sadie.API.Db.Models.Rooms;

public class RoomAdapter(Room room) : IRoom
{
    public int Id { get; init; } = room.Id;
    public required string Name { get; set; } = room.Name;
    public int LayoutId { get; set; } = room.LayoutId;
    public required RoomLayout Layout { get; set; } = room.Layout;
    public long OwnerId { get; init; } = room.OwnerId;
    public Player? Owner { get; set; } = room.Owner;
    public int MaxUsersAllowed { get; set; } = room.MaxUsersAllowed;
    public required string Description { get; set; } = room.Description;
    public bool IsMuted { get; init; } = room.IsMuted;
    public required RoomSettings Settings { get; set; } = room.Settings;
    public required RoomPaintSettings PaintSettings { get; set; } = room.PaintSettings;
    public RoomChatSettings? ChatSettings { get; set; } = room.ChatSettings;
    public required ICollection<RoomPlayerRight> PlayerRights { get; init; } = room.PlayerRights;
    public required ICollection<RoomChatMessage> ChatMessages { get; init; } = room.ChatMessages;
    public required ICollection<RoomTag> Tags { get; init; } = room.Tags;
    public required ICollection<PlayerRoomLike> PlayerLikes { get; init; } = room.PlayerLikes;
    public required ICollection<PlayerFurnitureItemPlacementData> FurnitureItems { get; init; } = room.FurnitureItems;
    public DateTimeOffset CreatedAt { get; init; } = room.CreatedAt;
    public Group? Group { get; init; } = room.Group;
    public RoomDimmerSettings? DimmerSettings { get; set; } = room.DimmerSettings;
    public required ICollection<PlayerRoomBan> PlayerBans { get; init; } = room.PlayerBans;
}
