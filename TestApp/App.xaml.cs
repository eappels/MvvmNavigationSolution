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
            return services.BuildServiceProvider();
        }
    }
}