using Avalonia.Controls;
using Avalonia.Media;

namespace Avalonia.NoAxaml;

public static class TextBlockExtension {
    public static T Text<T>(this T it, string? value) where T : TextBlock {
        it.Text = value; // 214
        return it;
    }

    public static T FontStyle<T>(this T it, FontStyle value) where T : TextBlock {
        it.FontStyle = value; // 241
        return it;
    }

    public static T FontStretch<T>(this T it, FontStretch value) where T : TextBlock {
        it.FontStretch = value; // 241
        return it;
    }
}
