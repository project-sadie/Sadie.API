namespace Sadie.API.Db.Models.Players;

public interface IPlayerBadge
{
    int Id { get; init; }
    long PlayerId { get; init; }
    int BadgeId { get; init; }
    IBadge? Badge { get; init; }
    int Slot { get; init; }
}