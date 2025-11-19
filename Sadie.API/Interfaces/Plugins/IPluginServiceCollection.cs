using Microsoft.Extensions.DependencyInjection;

namespace Sadie.API.Interfaces.Plugins;

public interface IPluginServiceCollection
{
    void Register(IServiceCollection serviceCollection);
}