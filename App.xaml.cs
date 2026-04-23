using Microsoft.Maui.Controls;
using System;

namespace lessApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    // Esta es la nueva forma correcta de arrancar la app en tu versión
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}