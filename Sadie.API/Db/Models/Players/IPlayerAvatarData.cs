using Sadie.Enums.Game.Players;
using Sadie.Enums.Miscellaneous;

namespace Sadie.API.Db.Models.Players;

public interface IPlayerAvatarData
{
    int Id { get; init; }
    long PlayerId { get; init; }
    IPlayer? Player { get; init; }
    string FigureCode { get; init; }
    string? Motto { get; init; }
    PlayerAvatarGender Gender { get; init; }
    ChatBubble ChatBubbleId { get; init; }
}