using Avalonia.Controls;

namespace Avalonia.NoAxaml;

public static class TextBlockExtension {
    public static T Text<T>(this T it, string? value) where T : TextBlock {
        it.Text = value; // 214
        return it;
    }
}
