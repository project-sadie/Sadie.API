using Sadie.Enums.Game.Players;

namespace Sadie.API.Db.Models.Players;

public interface IPlayerWardrobeItem
{
    int Id { get; init; }
    int SlotId { get; init; }
    string? FigureCode { get; init; }
    PlayerAvatarGender Gender { get; init; }
}