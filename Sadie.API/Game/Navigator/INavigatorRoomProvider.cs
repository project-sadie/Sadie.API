using Sadie.API.Game.Players;
using Sadie.Db.Models.Rooms;

namespace Sadie.API.Game.Navigator;

public interface INavigatorRoomProvider
{
    Task<List<Room>> GetRoomsForCategoryNameAsync(IPlayerLogic player, string category);
    Task<List<Room>> GetRoomsForSearchQueryAsync(string searchQuery);
}