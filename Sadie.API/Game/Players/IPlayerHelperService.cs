using Sadie.API.Db.Models.Players.Friendships;
using Sadie.API.Game.Players.Friendships;
using Sadie.API.Game.Players.Packets.Writers;

namespace Sadie.API.Game.Players;

public interface IPlayerHelperService
{
    Task SendFriendUpdatesToPlayerAsync(
        IPlayerLogic player, 
        List<IPlayerFriendshipUpdate> updates);

    Task SendPlayerFriendListUpdate(
        IPlayerLogic player, 
        IPlayerRepository playerRepository);

    IPlayerSubscriptionWriter? GetSubscriptionWriterAsync(IPlayerLogic player, string name);

    Task UpdatePlayerStatusForFriendsAsync(
        IPlayerLogic player, 
        IEnumerable<IPlayerFriendship> friendships, 
        bool isOnline, 
        bool inRoom,
        IPlayerRepository playerRepository);

    Task SendUnseenInventoryItemsAsync(IPlayerLogic player, List<IPlayerFurnitureItem> items);
    
    Task RefreshInventoryAsync(IPlayerLogic player);
}