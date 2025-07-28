using Sadie.API.Db.Models.Rooms;
using Sadie.API.Game.Players;

namespace Sadie.API.Game.Navigator;

public interface INavigatorRoomProvider
{
    Task<List<IRoom>> GetRoomsForCategoryNameAsync(IPlayerLogic player, string category);
    Task<List<IRoom>> GetRoomsForSearchQueryAsync(string searchQuery);
}