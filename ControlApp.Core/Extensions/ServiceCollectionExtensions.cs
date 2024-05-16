using ControlApp.Core.Interfaces;
using ControlApp.Core.Services;
using ControlApp.Core.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ControlApp.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddCoreServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<ILoginService, LoginService>();
        serviceCollection.AddTransient<IReportService, WordReportService>();
    }
}
