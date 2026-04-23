using Microsoft.Maui.Controls;
using System;

namespace lessApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // ESTA ES LA LÍNEA MÁGICA: Obliga a la app a verse blanca siempre
        Application.Current.UserAppTheme = AppTheme.Light;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}