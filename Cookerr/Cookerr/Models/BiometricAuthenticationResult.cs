using Cookerr.Models.Enums;

namespace Cookerr.Models;

public class BiometricAuthenticationResult
{
    public BiometricAuthenticationStatus Status { get; set; }  
    public string ErrorMessage { get; set; }
}