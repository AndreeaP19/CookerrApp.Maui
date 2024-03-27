using CommunityToolkit.Mvvm.Input;
using Cookerr.Models.Enums;
using Cookerr.Services;
using Cookerr.ViewModels.Base;

namespace Cookerr.ViewModels;

public partial class LoginViewModel: BaseViewModel
{
    private readonly IBiometricAuthenticationService _authService;
    private readonly INavigationService _navigationService;

    public LoginViewModel(IBiometricAuthenticationService authService, INavigationService navigationService)
    {
        _authService = authService;
        _navigationService = navigationService;
    }

    [RelayCommand]
    private async Task LoginAsync(CancellationToken cancellationToken)
    {
        var isBiometricAuthAvailable = await _authService.CheckIfBiometricsAreAvailableAsync();

        if (isBiometricAuthAvailable)
        {
            var authResult =
                await _authService.AuthenticateAsync("FaceID", "App requires FaceID in order to login");

            switch (authResult.Status)
            {
                case BiometricAuthenticationStatus.Success:
                    // handle success state
                    await Shell.Current.GoToAsync("///MainView", true);
                    break;
                case BiometricAuthenticationStatus.Failed:
                    // handle failed state
                    break;
                case BiometricAuthenticationStatus.Denied:
                    // handle denied state
                    break;
                case BiometricAuthenticationStatus.Unknown:
                case BiometricAuthenticationStatus.FallbackRequest:
                case BiometricAuthenticationStatus.Canceled:
                case BiometricAuthenticationStatus.TooManyAttempts:
                case BiometricAuthenticationStatus.NotAvailable:
                default:
                    // handle other states
                    break;
            }
        }
        else
        {
            await _navigationService.NavigateTo(NavigationNodes.UserNameAndPasswordView);
        }
    }
}