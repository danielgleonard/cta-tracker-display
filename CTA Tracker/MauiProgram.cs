using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace CTA_Tracker
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            var a = Assembly.GetExecutingAssembly();
            using var stream = a.GetManifestResourceStream("CTA_Tracker.config.json");

            var config = new ConfigurationBuilder()
                        .AddJsonStream(stream)
                        .Build();


            builder.Configuration.AddConfiguration(config);

            builder.Services.AddTransient<MainPage>();

            return builder.Build();
        }
    }
}
