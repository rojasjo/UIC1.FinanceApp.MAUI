using FinanceApp.Pages;

namespace FinanceApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute("Balance", typeof(Balance));
    }
}