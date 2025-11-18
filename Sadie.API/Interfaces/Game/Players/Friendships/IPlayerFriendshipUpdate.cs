using Sadie.API.DTOs.Player;

namespace Sadie.API.Interfaces.Game.Players.Friendships;

public interface IPlayerFriendshipUpdate
{
    int Type { get; init; }
    IFriendData? Friend { get; init; }
    bool FriendOnline { get; init; }
    bool FriendInRoom { get; init; }
    PlayerRelationshipTypeDto Relation { get; init; }
}