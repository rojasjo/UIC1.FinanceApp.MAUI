using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace FinanceApp.ViewModels;

public class MainViewModel : ObservableObject
{
    public ICommand NextPageCommand { get; }

    public MainViewModel()
    {
        NextPageCommand = new AsyncRelayCommand(Navigate);
    }

    private Task Navigate()
    {
        return Shell.Current.GoToAsync("/Balance");
    }
}