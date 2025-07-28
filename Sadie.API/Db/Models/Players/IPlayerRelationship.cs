namespace Sadie.API.Db.Models.Players;

public interface IPlayerRelationship
{
    int Id { get; init; }
    long OriginPlayerId { get; init; }
    IPlayer? OriginPlayer { get; init; }
    long TargetPlayerId { get; init; }
    IPlayer? TargetPlayer { get; init; }
    int TypeId { get; set; }
}