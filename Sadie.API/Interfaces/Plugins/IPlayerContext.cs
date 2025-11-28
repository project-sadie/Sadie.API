namespace Sadie.API.Interfaces.Plugins;

public interface IPluginContext : IAsyncDisposable
{
    Task BootstrapAsync();
}