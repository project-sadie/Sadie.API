using Sadie.API.Interfaces.Game.Players;

namespace Sadie.API.Interfaces.Game.Navigator;

public interface INavigatorRoomProvider
{
    Task<List<Room>> GetRoomsForCategoryNameAsync(IPlayerLogic player, string category);
    Task<List<Room>> GetRoomsForSearchQueryAsync(string searchQuery);
}