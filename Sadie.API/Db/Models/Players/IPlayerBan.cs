namespace Sadie.API.Db.Models.Players;

public interface IPlayerBan
{
    int Id { get; init; }
    long CreatorId { get; init; }
    IPlayer Creator { get; init; }
    long PlayerId { get; init; }
    IPlayer Player { get; init; }
    string Reason { get; init; }
    DateTimeOffset CreatedAt { get; init; }
    DateTimeOffset? ExpiresAt { get; init; }
}