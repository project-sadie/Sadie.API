using Sadie.Core.Shared.Attributes;

namespace Sadie.API.Interfaces.Game.Players.Friendships;

public interface IPlayerFriendshipRequestData
{
    [PacketData] long Id { get; init; }
    [PacketData] string Username { get; init; }
    [PacketData] string FigureCode { get; init; }
}