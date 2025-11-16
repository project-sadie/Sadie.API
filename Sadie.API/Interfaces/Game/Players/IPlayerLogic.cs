using System.Text.RegularExpressions;
using DotNetty.Transport.Channels;
using Sadie.API.DTOs;
using Sadie.API.DTOs.Player;
using Sadie.API.DTOs.Player.Furniture;
using Sadie.API.DTOs.Rooms;
using Sadie.API.DTOs.Server;

namespace Sadie.API.Interfaces.Game.Players;

public interface IPlayerLogic
{
    long Id { get; init; }
    string Username { get; init; }
    string Email { get; init; }
    ICollection<RoleDto> Roles { get; init; }
    DateTimeOffset CreatedAt { get; init; }
    PlayerDataDto Data { get; set; }
    PlayerAvatarDataDto? AvatarData { get; set; }
    List<PlayerTagDto> Tags { get; init; }
    ICollection<PlayerRoomLikeDto> RoomLikes { get; init; }
    ICollection<PlayerRelationshipDto> Relationships { get; init; }
    PlayerNavigatorSettingsDto? NavigatorSettings { get; set; }
    PlayerGameSettingsDto? GameSettings { get; set; }
    ICollection<PlayerBadgeDto> Badges { get; init; }
    ICollection<PlayerFurnitureItemDto> FurnitureItems { get; init; }
    ICollection<PlayerWardrobeItemDto> WardrobeItems { get; init; }
    ICollection<PlayerSubscriptionDto> Subscriptions { get; init; }
    ICollection<PlayerRespectDto> Respects { get; init; }
    ICollection<PlayerSavedSearchDto> SavedSearches { get; init; }
    ICollection<PlayerFriendshipDto> OutgoingFriendships { get; init; }
    ICollection<PlayerFriendshipDto> IncomingFriendships { get; init; }
    ICollection<ServerPeriodicCurrencyRewardLogDto> RewardLogs { get; init; }
    ICollection<RoomDto> Rooms { get; set; }
    ICollection<PlayerIgnoreDto> Ignores { get; set; }
    ICollection<Group> Groups { get; init; }
    ICollection<PlayerBotDto> Bots { get; init; }
    ICollection<PlayerRoomVisitDto> RoomVisits { get; init; }
    int GetAcceptedFriendshipCount();
    List<PlayerFriendshipDto> GetMergedFriendships();
    bool IsFriendsWith(int targetId);
    PlayerFriendshipDto? TryGetAcceptedFriendshipFor(long targetId);
    PlayerFriendshipDto? TryGetFriendshipFor(long targetId);
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