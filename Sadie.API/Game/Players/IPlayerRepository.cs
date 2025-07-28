using Sadie.API.Db.Models.Players;
using Sadie.API.Networking;

namespace Sadie.API.Game.Players;

public interface IPlayerRepository
{
    IPlayerLogic? GetPlayerLogicById(long id);
    IPlayerLogic? GetPlayerLogicByUsername(string username);
    Task<IPlayer?> GetPlayerByIdAsync(long id);
    Task<IPlayer?> GetPlayerByUsernameAsync(string username);
    ICollection<IPlayerLogic> GetAll();
    bool TryAddPlayer(IPlayerLogic player);
    Task<bool> TryRemovePlayerAsync(long playerId);
    long Count();
    Task<List<IPlayer>> GetPlayersForSearchAsync(string searchQuery, long[] excludeIds);
    Task<List<IPlayerRelationship>> GetRelationshipsForPlayerAsync(long playerId);
    Task BroadcastDataAsync(AbstractPacketWriter writer);
}