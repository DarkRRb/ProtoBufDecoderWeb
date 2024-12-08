using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Avalonia.NoAxaml;

public static class MenuItemExtension {
    public static T OnClick<T>(this T it, EventHandler<RoutedEventArgs> value) where T : MenuItem {
        it.Click += value; // 67
        return it;
    }
}
