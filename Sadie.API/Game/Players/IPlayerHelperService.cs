using Sadie.API.Game.Players.Friendships;
using Sadie.API.Game.Players.Packets.Writers;
using Sadie.Db.Models.Players;
using Sadie.Db.Models.Players.Furniture;

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
        IEnumerable<PlayerFriendship> friendships, 
        bool isOnline, 
        bool inRoom,
        IPlayerRepository playerRepository);

    Task SendUnseenInventoryItemsAsync(IPlayerLogic player, List<PlayerFurnitureItem> items);
    
    Task RefreshInventoryAsync(IPlayerLogic player);
}