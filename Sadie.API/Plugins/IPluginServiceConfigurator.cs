using Microsoft.Extensions.DependencyInjection;

namespace Sadie.API.Plugins;

public interface IPluginServiceConfigurator
{
    Task RegisterServicesAsync(IServiceCollection serviceCollection);
}