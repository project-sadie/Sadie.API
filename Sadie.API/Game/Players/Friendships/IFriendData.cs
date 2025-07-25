using Sadie.Enums.Game.Players;

namespace Sadie.API.Game.Players.Friendships;

public interface IFriendData
{
    string Motto { get; init; }
    PlayerAvatarGender Gender { get; init; }
    long Id { get; init; }
    string Username { get; init; }
    string FigureCode { get; init; }
}