using Cookerr.Services;
using Cookerr.Views;

namespace Cookerr;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(NavigationNodes.LoginView, typeof(LoginView));
        Routing.RegisterRoute(NavigationNodes.UserNameAndPasswordView, typeof(UserNameAndPasswordView));
    }
}