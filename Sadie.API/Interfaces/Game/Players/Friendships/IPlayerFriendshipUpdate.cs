using Sadie.API.DTOs.Player;
using Sadie.Core.Enums.Game.Players;

namespace Sadie.API.Interfaces.Game.Players.Friendships;

public interface IPlayerFriendshipUpdate
{
    int Type { get; init; }
    IFriendData? Friend { get; init; }
    bool FriendOnline { get; init; }
    bool FriendInRoom { get; init; }
    PlayerRelationshipType Relation { get; init; }
}