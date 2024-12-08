using Avalonia.Controls;

namespace Avalonia.NoAxaml;

public static class PanelExtension {
    public static T Children<T>(this T it, params Control[] value) where T : Panel {
        it.Children.AddRange(value); // 50
        return it;
    }

    public static T Child<T>(this T it, Control value) where T : Panel {
        it.Children.Add(value); // 50
        return it;
    }
}
