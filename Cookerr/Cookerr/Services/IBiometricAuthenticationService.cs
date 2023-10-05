using Cookerr.Models;

namespace Cookerr.Services;

public interface IBiometricAuthenticationService
{
    public Task<bool> CheckIfBiometricsAreAvailableAsync();
    public Task<BiometricAuthenticationResult> AuthenticateAsync( string title, string message);
}