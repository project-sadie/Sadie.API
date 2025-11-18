using Sadie.API.DTOs.Player.Furniture;
using Sadie.API.Interfaces.Networking;

namespace Sadie.API.Interfaces.Game.Rooms.Users;

public interface IRoomUserTrade
{
    List<IRoomUser> Users { get; init; }
    List<PlayerFurnitureItemDto> Items { get; init; }
    void OfferItems(List<PlayerFurnitureItemDto> playerItems);
    Task BroadcastToUsersAsync(AbstractPacketWriter writer);
    Task SwapItemsAsync();
    void RemoveOfferedItem(PlayerFurnitureItemDto item);
}