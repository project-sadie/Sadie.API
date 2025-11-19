using Sadie.API.DTOs.Rooms;
using Sadie.API.Interfaces.Game.Players;

namespace Sadie.API.Interfaces.Game.Navigator;

public interface INavigatorRoomProvider
{
    Task<List<RoomDto>> GetRoomsForCategoryNameAsync(IPlayerLogic player, string category);
    Task<List<RoomDto>> GetRoomsForSearchQueryAsync(string searchQuery);
}