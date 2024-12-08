using Avalonia.Controls;

namespace Avalonia.NoAxaml;

public static class ControlExtension {
    public static T ContextMenu<T>(this T it, ContextMenu? value) where T : Control {
        it.ContextMenu = value; // 132
        return it;
    }
}
