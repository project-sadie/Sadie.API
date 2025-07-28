using Sadie.Enums.Game.Players;

namespace Sadie.API.Db.Models.Players.Friendships;

public interface IPlayerFriendship
{
    int Id { get; init; }
    long OriginPlayerId { get; init; }
    IPlayer? OriginPlayer { get; init; }
    long TargetPlayerId { get; init; }
    IPlayer? TargetPlayer { get; init; }
    PlayerFriendshipStatus Status { get; set; }
    DateTimeOffset CreatedAt { get; set; }
}