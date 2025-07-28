using System.Text.RegularExpressions;
using DotNetty.Transport.Channels;
using Sadie.API.Db.Models;
using Sadie.API.Db.Models.Players;
using Sadie.API.Db.Models.Players.Friendships;
using Sadie.API.Db.Models.Rooms;
using Sadie.API.Db.Models.Server;

namespace Sadie.API.Game.Players;

public interface IPlayerLogic
{
    long Id { get; init; }
    string Username { get; init; }
    string Email { get; init; }
    ICollection<IRole> Roles { get; init; }
    DateTime CreatedAt { get; init; }
    IPlayerData Data { get; init; }
    IPlayerAvatarData? AvatarData { get; init; }
    List<IPlayerTag> Tags { get; init; }
    ICollection<IPlayerRoomLike> RoomLikes { get; init; }
    ICollection<IPlayerRelationship> Relationships { get; init; }
    IPlayerNavigatorSettings? NavigatorSettings { get; init; }
    IPlayerGameSettings? GameSettings { get; init; }
    ICollection<IPlayerBadge> Badges { get; init; }
    ICollection<IPlayerFurnitureItem> FurnitureItems { get; init; }
    ICollection<IPlayerWardrobeItem> WardrobeItems { get; init; }
    ICollection<IPlayerSubscription> Subscriptions { get; init; }
    ICollection<IPlayerRespect> Respects { get; init; }
    ICollection<IPlayerSavedSearch> SavedSearches { get; init; }
    ICollection<IPlayerFriendship> OutgoingFriendships { get; init; }
    ICollection<IPlayerFriendship> IncomingFriendships { get; init; }
    ICollection<IServerPeriodicCurrencyRewardLog> RewardLogs { get; init; }
    ICollection<IRoom> Rooms { get; set; }
    ICollection<IPlayerIgnore> Ignores { get; set; }
    ICollection<Group> Groups { get; init; }
    ICollection<IPlayerBot> Bots { get; init; }
    ICollection<IPlayerRoomVisit> RoomVisits { get; init; }
    int GetAcceptedFriendshipCount();
    List<IPlayerFriendship> GetMergedFriendships();
    bool IsFriendsWith(int targetId);
    IPlayerFriendship? TryGetAcceptedFriendshipFor(long targetId);
    IPlayerFriendship? TryGetFriendshipFor(long targetId);
    void DeleteFriendshipFor(long targetId);
    bool HasPermission(string name);
    IPlayerState State { get; }
    IChannel? Channel { get; set; }
    INetworkObject? NetworkObject { get; set; }
    bool Authenticated { get; set; }
    ValueTask DisposeAsync();
    bool DeservesReward(string? rewardType, int intervalInSeconds);
    Task SendAlertAsync(string message);
}