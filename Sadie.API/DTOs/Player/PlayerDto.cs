using Sadie.API.DTOs.Player.Furniture;
using Sadie.API.DTOs.Rooms;
using Sadie.API.DTOs.Server;

namespace Sadie.API.DTOs.Player;

public record PlayerDto(
    long Id,
    string Username,
    string Email,
    List<RoleDto> Roles,
    DateTimeOffset CreatedAt,
    PlayerDataDto? Data,
    PlayerAvatarDataDto? AvatarData,
    List<PlayerTagDto> Tags,
    ICollection<PlayerRoomLikeDto> RoomLikes,
    ICollection<PlayerRelationshipDto> Relationships,
    PlayerNavigatorSettingsDto? NavigatorSettings,
    PlayerGameSettingsDto? GameSettings,
    List<PlayerBadgeDto> Badges,
    ICollection<PlayerFurnitureItemDto> FurnitureItems,
    ICollection<PlayerWardrobeItemDto> WardrobeItems,
    List<PlayerSubscriptionDto> Subscriptions,
    ICollection<PlayerRespectDto> Respects,
    ICollection<PlayerSavedSearchDto> SavedSearches,
    ICollection<PlayerFriendshipDto> OutgoingFriendships,
    ICollection<PlayerFriendshipDto> IncomingFriendships,
    ICollection<ServerPeriodicCurrencyRewardLogDto> RewardLogs,
    ICollection<RoomDto> Rooms,
    ICollection<PlayerIgnoreDto> Ignores,
    ICollection<PlayerBotDto> Bots,
    ICollection<PlayerRoomVisitDto> RoomVisits,
    ICollection<PlayerBanDto> Bans,
    ICollection<PlayerSsoTokenDto> Tokens
);