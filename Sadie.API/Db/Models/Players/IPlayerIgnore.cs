namespace Sadie.API.Db.Models.Players;

public interface IPlayerIgnore
{
    int Id { get; init; }
    long PlayerId { get; init; }
    long TargetPlayerId { get; init; }
}