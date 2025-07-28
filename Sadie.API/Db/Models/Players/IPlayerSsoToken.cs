namespace Sadie.API.Db.Models.Players;

public interface IPlayerSsoToken
{
    int Id { get; init; }
    long PlayerId { get; init; }
    string? Token { get; init; }
    DateTimeOffset CreatedAt { get; init; }
    DateTimeOffset ExpiresAt { get; init; }
    DateTimeOffset? UsedAt { get; set; }
}