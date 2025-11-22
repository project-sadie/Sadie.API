namespace Sadie.API.DTOs.Player;

public record PlayerDto
{
    public long Id { get; init; }
    public string Username { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public DateTimeOffset CreatedAt { get; init; }
    public PlayerDataDto? Data { get; init; }
    public PlayerAvatarDataDto? AvatarData { get; init; }
    public List<string> Roles { get; init; } = [];
    public List<string> Tags { get; init; } = [];
    public List<PlayerBadgeDto> Badges { get; init; } = [];
    public List<PlayerSubscriptionDto> Subscriptions { get; init; } = [];
    public PlayerNavigatorSettingsDto? NavigatorSettings { get; init; }
    public PlayerGameSettingsDto? GameSettings { get; init; }
    public ICollection<PlayerFriendshipDto> OutgoingFriendships { get; init; } = [];
    public ICollection<PlayerFriendshipDto> IncomingFriendships { get; init; } = [];
}