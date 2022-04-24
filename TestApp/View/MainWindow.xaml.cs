using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using TestApp.ViewModel;

namespace TestApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService<MainWindowViewModel>();
        }
    }
}