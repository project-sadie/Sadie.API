namespace Sadie.API.Db.Models.Players;

public interface IPlayerRespect
{
    int Id { get; init; }
    long OriginPlayerId { get; init; }
    IPlayer? OriginPlayer { get; init; }
    long TargetPlayerId { get; init; }
    IPlayer? TargetPlayer { get; init; }
}