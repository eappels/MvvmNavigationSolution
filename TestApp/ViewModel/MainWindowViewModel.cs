using System;
using System.Windows.Input;
using TestApp.Helper;

namespace TestApp.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {

        public ICommand viewCommand { get; set; }
        private int _switchView;

        public MainWindowViewModel()
        {
            viewCommand = new RelayCommand(viewCommand_Clicked, CanviewCommandBe_Clicked);
            SwitchView = 0;
        }

        public int SwitchView
        {
            get => _switchView;
            set => SetProperty(ref _switchView, value);
        }

        private void viewCommand_Clicked(object value)
        {
            SwitchView = Convert.ToInt32(value);
        }

        private bool CanviewCommandBe_Clicked(object value)
        {
            return SwitchView != Convert.ToInt32(value);
        }
    }
}