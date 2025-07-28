namespace Sadie.API.Db.Models.Players;

public interface IPlayerData
{
    int Id { get; init; }
    IPlayer Player { get; init; }
    long PlayerId { get; init; }
    int? HomeRoomId { get; set; }
    int CreditBalance { get; set; }
    int PixelBalance { get; set; }
    int SeasonalBalance { get; set; }
    int GotwPoints { get; set; }
    int RespectPoints { get; set; }
    int RespectPointsPet { get; init; }
    int AchievementScore { get; init; }
    bool AllowFriendRequests { get; init; }
    bool IsOnline { get; set; }
    DateTimeOffset? LastOnline { get; set; }
}