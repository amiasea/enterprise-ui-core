using Microsoft.Extensions.DependencyInjection;

namespace Amiasea.Enterprise.Ui.Core;

public static class CoreUiServiceCollectionExtensions
{
    public static IServiceCollection AddCoreUi(
        this IServiceCollection services)
    {
        services
            .AddCoreClient();

        return services;
    }
}