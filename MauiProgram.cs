using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;

namespace lessApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        // Aquí es donde llama a tu archivo App
        builder.UseMauiApp<App>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}