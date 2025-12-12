using Sadie.API.DTOs.Players.Furniture;
using Sadie.API.Interfaces.Networking;

namespace Sadie.API.Interfaces.Game.Rooms.Users;

public interface IRoomUserTrade
{
    List<IRoomUser> Users { get; init; }
    List<PlayerFurnitureItemDto> Items { get; init; }
    Task OfferItemsAsync(List<PlayerFurnitureItemDto> playerItems);
    Task BroadcastToUsersAsync(AbstractPacketWriter writer);
    Task SwapItemsAsync();
    void RemoveOfferedItem(PlayerFurnitureItemDto item);
}