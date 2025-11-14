namespace Sadie.API.DTOs.Player;

public class PlayerRelationshipDto
{
    public int Id { get; init; }
    public long OriginPlayerId { get; init; }
    public long TargetPlayerId { get; init; }
    public int TypeId { get; init; }
}
