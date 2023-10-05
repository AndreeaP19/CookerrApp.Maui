using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Cookerr.Services;
using Cookerr.ViewModels;
using Cookerr.Views;

namespace Cookerr;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .RegisterServices()
            .RegisterViews()
            .RegisterViewModels()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }

    private static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<IBiometricAuthenticationService, BiometricAuthenticationService>();
        return mauiAppBuilder;
    }

    private static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<LoginView>();
        mauiAppBuilder.Services.AddTransient<UserNameAndPasswordView>();
        mauiAppBuilder.Services.AddTransient<MainPage>();

        return mauiAppBuilder;
    }

    private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<LoginViewModel>();
        mauiAppBuilder.Services.AddTransient<UserNameAndPasswordViewModel>();

        return mauiAppBuilder;
    }
}