using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using TestApp.ViewModel;

namespace TestApp
{
    public partial class App : Application
    {

        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }

        public App()
        {
            Services = ConfigureServices();
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<MainWindow>();
            return services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var window = this.Services.GetService<MainWindow>();
            window.Show();
            base.OnStartup(e);
        }
    }
}