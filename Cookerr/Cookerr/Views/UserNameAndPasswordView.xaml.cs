namespace Cookerr.Views;

public partial class UserNameAndPasswordView : ContentPage
{
    public UserNameAndPasswordView()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(UserNameEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
        {
            Shell.Current.GoToAsync("///MainView", true);
        }
    }
}