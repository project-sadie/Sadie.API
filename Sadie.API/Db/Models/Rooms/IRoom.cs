using System.Text.RegularExpressions;
using Sadie.API.Db.Models.Players;
using Sadie.API.Db.Models.Players.Furniture;
using Sadie.API.Db.Models.Rooms.Chat;
using Sadie.API.Db.Models.Rooms.Rights;
using Sadie.API.Game.Rooms;

namespace Sadie.API.Db.Models.Rooms;

public interface IRoom
{
    int Id { get; init; }
    string Name { get; set; }
    int LayoutId { get; set; }
    IRoomLayout? Layout { get; set; }
    long OwnerId { get; init; }
    IPlayer Owner { get; set; }
    int MaxUsersAllowed { get; set; }
    string Description { get; set; }
    bool IsMuted { get; init; }
    IRoomSettings Settings { get; set; }
    IRoomPaintSettings? PaintSettings { get; set; }
    IRoomChatSettings? ChatSettings { get; set; }
    ICollection<IRoomPlayerRight> PlayerRights { get; init; }
    ICollection<IRoomChatMessage> ChatMessages { get; init; }
    ICollection<IRoomTag> Tags { get; init; }
    ICollection<IPlayerRoomLike> PlayerLikes { get; init; }
    ICollection<IPlayerFurnitureItemPlacementData> FurnitureItems { get; init; }
    DateTime CreatedAt { get; init; }
    Group? Group { get; init; }
    IRoomDimmerSettings? DimmerSettings { get; set; }
    ICollection<IPlayerRoomBan> PlayerBans { get; init; }
}