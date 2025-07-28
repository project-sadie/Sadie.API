using System.Security;
using Sadie.API.Db.Models.Players;

namespace Sadie.API.Db.Models;

public interface IRole
{
    int Id { get; init; }
    string Name { get; init; }
    ICollection<IPlayer> Players { get; init; }
    ICollection<IPermission> Permissions { get; init; }
}