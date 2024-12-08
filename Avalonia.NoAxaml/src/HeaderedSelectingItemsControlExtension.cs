using Avalonia.Controls.Primitives;

namespace Avalonia.NoAxaml;

public static class HeaderedSelectingItemsControlExtension {
    public static T Header<T>(this T it, object? value) where T : HeaderedSelectingItemsControl {
        it.Header = value; // 41
        return it;
    }
}
