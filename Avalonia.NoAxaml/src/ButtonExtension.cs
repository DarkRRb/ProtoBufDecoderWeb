using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Avalonia.NoAxaml;

public static class ButtonExtension {
    public static T OnClick<T>(this T it, EventHandler<RoutedEventArgs> value) where T : Button {
        it.Click += value; // 67
        return it;
    }
}
