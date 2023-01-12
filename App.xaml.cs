using DemoWPF.Library;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace DemoWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost?  AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices(
                  (hostContext, services) => {
                      services.AddSingleton<MainWindow>();
                      services.AddSingleton<IDataAccess, DataAccess>();
                  })
                .Build();
        }


        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();

            var startupWindow = AppHost.Services.GetRequiredService<MainWindow>();
            startupWindow?.Show();
            base.OnStartup(e);
        }




    }
}
