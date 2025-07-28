using System.Text.RegularExpressions;
using Sadie.API.Db.Models.Players.Friendships;
using Sadie.API.Db.Models.Players.Furniture;
using Sadie.API.Db.Models.Rooms;
using Sadie.API.Db.Models.Server;

namespace Sadie.API.Db.Models.Players;

public interface IPlayer
{
    long Id { get; init; }
    string Username { get; init; }
    string Email { get; init; }
    string Password { get; init; }
    ICollection<IRole> Roles { get; init; }
    DateTimeOffset CreatedAt { get; init; }
    IPlayerData? Data { get; init; }
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
    ICollection<IPlayerBan> Bans { get; init; }
    int GetAcceptedFriendshipCount();
    List<IPlayerFriendship> GetMergedFriendships();
    bool IsFriendsWith(int targetId);
    IPlayerFriendship? TryGetAcceptedFriendshipFor(long targetId);
    IPlayerFriendship? TryGetFriendshipFor(long targetId);
    void DeleteFriendshipFor(long targetId);
    bool HasPermission(string name);
}