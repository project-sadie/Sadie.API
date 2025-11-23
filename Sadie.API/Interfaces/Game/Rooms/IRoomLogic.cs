using Sadie.API.DTOs;
using Sadie.API.DTOs.Player;
using Sadie.API.DTOs.Player.Furniture;
using Sadie.API.DTOs.Rooms;
using Sadie.API.DTOs.Rooms.Chat;
using Sadie.API.DTOs.Rooms.Rights;
using Sadie.API.Interfaces.Game.Rooms.Bots;
using Sadie.API.Interfaces.Game.Rooms.Mapping;
using Sadie.API.Interfaces.Game.Rooms.Users;

namespace Sadie.API.Interfaces.Game.Rooms;

public interface IRoomLogic : IAsyncDisposable
{
    IRoomTileMap TileMap { get; }
    IRoomUserRepository UserRepository { get; }
    IRoomBotRepository BotRepository { get; }
    int IdleTicks { get; set; }
    int Id { get; set; }
    string Name { get; set; }
    RoomLayoutDto? Layout { get; set; }
    long OwnerId { get; set; }
    PlayerDto? Owner { get; set; }
    int MaxUsersAllowed { get; set; }
    string Description { get; set; }
    bool IsMuted { get; set; }
    RoomSettingsDto? Settings { get; set; }
    RoomPaintSettingsDto? PaintSettings { get; set; }
    RoomChatSettingsDto? ChatSettings { get; set; }
    ICollection<RoomPlayerRightDto> PlayerRights { get; init; }
    ICollection<RoomChatMessageDto> ChatMessages { get; init; }
    ICollection<RoomTagDto> Tags { get; init; }
    ICollection<PlayerRoomLikeDto> PlayerLikes { get; init; }
    ICollection<PlayerFurnitureItemPlacementDataDto> FurnitureItems { get; init; }
    DateTimeOffset CreatedAt { get; init; }
    GroupDto? Group { get; init; }
    RoomDimmerSettingsDto? DimmerSettings { get; set; }
    ValueTask DisposeAsync();
}