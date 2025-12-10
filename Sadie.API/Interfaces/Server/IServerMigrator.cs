namespace Sadie.API.Interfaces.Server;

public interface IServerMigrator
{
    Task MigrateAsync(CancellationToken token);
}