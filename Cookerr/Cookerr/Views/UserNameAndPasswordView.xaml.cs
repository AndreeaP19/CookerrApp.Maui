using Cookerr.ViewModels;

namespace Cookerr.Views;

public partial class UserNameAndPasswordView : ContentPage
{
    public UserNameAndPasswordView(UserNameAndPasswordViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}