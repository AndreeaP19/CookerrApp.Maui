namespace Cookerr.Models.Enums;

public enum BiometricAuthenticationStatus
{
    Unknown, 
    Success,
    FallbackRequest,
    Failed,
    Canceled,
    TooManyAttempts,
    NotAvailable,
    Denied
}