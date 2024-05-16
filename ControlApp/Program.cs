using ControlApp.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ControlApp.Infrastructure.Extensions;

namespace ControlApp;

internal static class Program
{
    private static CancellationTokenSource cancellationTokenSource = new();
    private static ApplicationContext applicationContext = null!;
    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    [STAThread]
    static void Main()
    {
        ServiceProvider = ConfigureServices();
        Application.ApplicationExit += Application_ApplicationExit;
        ApplicationConfiguration.Initialize();
        using SplashForm splash = new SplashForm();

        splash.Show();
        applicationContext = new ApplicationContext(ServiceProvider.GetRequiredService<EnterForm>());
        splash.Close();

        Application.Run(applicationContext);
    }

    private static IServiceProvider ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();
        services.AddSingleton(x => GetConfig());
        services.AddCoreServices();
        services.AddInfrastructure();
        services.AddForms();
        services.AddUserControls();

        return services.BuildServiceProvider();
    }

    public static void ChangeForm<TForm>(string? name)
        where TForm : Form
    {
        var form = ServiceProvider.GetRequiredService<TForm>();
        form.Text = name ?? form.Text;
        applicationContext.MainForm = form;
        form.Show();
    }

    private static void Application_ApplicationExit(object? sender, EventArgs e)
    {
        cancellationTokenSource?.Cancel();
    }

    private static IConfiguration GetConfig()
    {
        return new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
    }
}