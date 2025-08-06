using Microsoft.Extensions.DependencyInjection;

namespace Sadie.API.Plugins;

public interface IPluginServiceCollection
{
    void Register(IServiceCollection serviceCollection);
}