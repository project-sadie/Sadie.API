using Sadie.API.DTOs.Players;
using Sadie.API.Interfaces.Networking;

namespace Sadie.API.Interfaces.Game.Players;

public interface IPlayerRepository
{
    IPlayerLogic? GetPlayerLogicById(long id);
    IPlayerLogic? GetPlayerLogicByUsername(string username);
    Task<PlayerDto?> GetPlayerByIdAsync(long id);
    Task<PlayerDto?> GetPlayerByUsernameAsync(string username);
    ICollection<IPlayerLogic> GetAll();
    bool TryAddPlayer(IPlayerLogic player);
    Task<bool> TryRemovePlayerAsync(long playerId);
    long Count();
    Task<List<PlayerDto>> GetPlayersForSearchAsync(string searchQuery, long[] excludeIds);
    Task<List<PlayerRelationshipDto>> GetRelationshipsForPlayerAsync(long playerId);
    Task BroadcastDataAsync(AbstractPacketWriter writer);
    Task<string?> GetPlayerUsernameByIdAsync(long playerId);
}