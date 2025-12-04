using DotNetty.Transport.Channels;
using Sadie.API.DTOs.Player;

namespace Sadie.API.Interfaces.Game.Players;

public interface IPlayerLogic
{
    PlayerDto Player { get; }
    int GetAcceptedFriendshipCount();
    List<PlayerFriendshipDto> GetMergedFriendships();
    bool IsFriendsWith(int targetId);
    PlayerFriendshipDto? TryGetAcceptedFriendshipFor(long targetId);
    PlayerFriendshipDto? TryGetFriendshipFor(long targetId);
    void DeleteFriendshipFor(long targetId);
    bool HasPermission(string name);
    INetworkObject? NetworkObject { get; set; }
    IPlayerState State { get; }
    bool Authenticated { get; set; }
    ValueTask DisposeAsync();
    bool DeservesReward(string? rewardType, int intervalInSeconds);
    Task SendAlertAsync(string message);
}