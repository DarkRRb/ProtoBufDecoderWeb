using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Styling;
using Avalonia.Themes.Fluent;
using ProtoBufDecoderWeb.Views;

namespace ProtoBufDecoderWeb;

public class App : Application {
    public override void Initialize() {
        RequestedThemeVariant = ThemeVariant.Default;

        Styles.Add(new FluentTheme());
    }

    public override void OnFrameworkInitializationCompleted() {
        if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform) {
            singleViewPlatform.MainView = new MainView();
        } else throw new PlatformNotSupportedException();

        base.OnFrameworkInitializationCompleted();
    }
}