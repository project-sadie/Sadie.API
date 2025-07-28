using Sadie.Enums.Game.Rooms;

namespace Sadie.API.Db.Models.Rooms;

public interface IRoomSettings
{
    int Id { get; init; }
    int RoomId { get; init; }
    bool WalkDiagonal { get; init; }
    RoomAccessType AccessType { get; init; }
    string? Password { get; init; }
    int WhoCanMute { get; init; }
    int WhoCanKick { get; init; }
    int WhoCanBan { get; init; }
    bool AllowPets { get; init; }
    bool CanPetsEat { get; init; }
    bool HideWalls { get; init; }
    int WallThickness { get; init; }
    int FloorThickness { get; init; }
    bool CanUsersOverlap { get; init; }
    RoomTradeOption TradeOption { get; init; }
}