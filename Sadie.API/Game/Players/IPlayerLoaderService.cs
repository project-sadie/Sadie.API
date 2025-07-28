using Sadie.API.Db.Models.Players;

namespace Sadie.API.Game.Players;

public interface IPlayerLoaderService
{
    Task<IPlayerSsoToken?> GetTokenAsync(string token, int delayMs);
}