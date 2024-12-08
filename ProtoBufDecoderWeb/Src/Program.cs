using System.Threading.Tasks;
using Avalonia;
using Avalonia.Browser;
using Avalonia.Media;

namespace ProtoBufDecoderWeb;

internal sealed partial class Program {
    private static Task Main(string[] args) => BuildAvaloniaApp()
            .StartBrowserAppAsync("out");

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .With(new FontManagerOptions {
                DefaultFamilyName = "avares://ProtoBufDecoderWeb/Assets/Fonts/Inconsolata#Inconsolata",
                FontFallbacks = [new FontFallback {
                    FontFamily = new("avares://ProtoBufDecoderWeb/Assets/Fonts/Noto Sans SC#Noto Sans SC")
                }]
            });
}