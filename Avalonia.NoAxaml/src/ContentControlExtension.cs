using Avalonia.Controls;
using Avalonia.Layout;

namespace Avalonia.NoAxaml;

public static class ContentControlExtension {
    public static T Content<T>(this T it, object? value) where T : ContentControl {
        it.Content = value; // 67
        return it;
    }
    
    public static T HorizontalContentAlignment<T>(this T it, HorizontalAlignment value) where T : ContentControl {
        it.HorizontalContentAlignment = value; // 94
        return it;
    }

    public static T VerticalContentAlignment<T>(this T it, VerticalAlignment value) where T : ContentControl {
        it.VerticalContentAlignment = value; // 103
        return it;
    }
}
