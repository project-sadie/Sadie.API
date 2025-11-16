namespace Sadie.API.DTOs.Player;

public record PlayerDataDto
{
    public int CreditBalance { get; init; }
    public int PixelBalance { get; init; }
    public int SeasonalBalance { get; init; }
    public int GotwPoints { get; init; }
    public int RespectPoints { get; init; }
    public int RespectPointsPet { get; init; }
    public int AchievementScore { get; init; }
    public bool AllowFriendRequests { get; init; }
    public bool IsOnline { get; init; }
    public DateTimeOffset? LastOnline { get; init; }
}