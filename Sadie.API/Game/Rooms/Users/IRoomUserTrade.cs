using Sadie.API.Db.Models.Players.Furniture;
using Sadie.API.Networking;

namespace Sadie.API.Game.Rooms.Users;

public interface IRoomUserTrade
{
    List<IRoomUser> Users { get; init; }
    List<IPlayerFurnitureItem> Items { get; init; }
    void OfferItems(List<IPlayerFurnitureItem> playerItems);
    Task BroadcastToUsersAsync(AbstractPacketWriter writer);
    Task SwapItemsAsync();
    void RemoveOfferedItem(IPlayerFurnitureItem item);
}