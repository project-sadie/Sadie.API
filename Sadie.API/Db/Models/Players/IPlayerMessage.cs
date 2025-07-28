namespace Sadie.API.Db.Models.Players;

public interface IPlayerMessage
{
    int Id { get; init; }
    long OriginPlayerId { get; init; }
    IPlayer? OriginPlayer { get; init; }
    long TargetPlayerId { get; init; }
    IPlayer? TargetPlayer { get; init; }
    string? Message { get; init; }
    DateTimeOffset CreatedAt { get; init; }
}