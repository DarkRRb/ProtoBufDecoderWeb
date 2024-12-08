using Avalonia.Layout;

namespace Avalonia.NoAxaml;

public static class LayoutableExtension {
    public static T Margin<T>(this T it, Thickness value) where T : Layoutable {
        it.Margin = value; // 279
        return it;
    }

    public static T Margin<T>(this T it, double uniformLength) where T : Layoutable {
        it.Margin = new(uniformLength); // 279
        return it;
    }

    public static T Margin<T>(this T it, double left, double top, double right, double bottom) where T : Layoutable {
        it.Margin = new(left, top, right, bottom); // 279
        return it;
    }

    public static T HorizontalAlignment<T>(this T it, HorizontalAlignment value) where T : Layoutable {
        it.HorizontalAlignment = value; // 288
        return it;
    }

    public static T VerticalAlignment<T>(this T it, VerticalAlignment value) where T : Layoutable {
        it.VerticalAlignment = value; // 297
        return it;
    }
}
