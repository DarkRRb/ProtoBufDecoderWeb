using Avalonia.Controls;

namespace Avalonia.NoAxaml;

public static class TreeViewExtension {
    public static T AutoScrollToSelectedItem<T>(this T it, bool  value) where T : TreeView {
        it.AutoScrollToSelectedItem = value; // 92
        return it;
    }
}
