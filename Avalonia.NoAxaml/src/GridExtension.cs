using Avalonia.Controls;

namespace Avalonia.NoAxaml;

public static class GridExtension {
    public static T ColumnDefinitions<T>(this T it, params ColumnDefinition[] value) where T : Grid {
        it.ColumnDefinitions.AddRange(value); // 168
        return it;
    }

    public static T ColumnDefinition<T>(this T it, ColumnDefinition value) where T : Grid {
        it.ColumnDefinitions.Add(value); // 168
        return it;
    }

    public static T RowDefinitions<T>(this T it, params RowDefinition[] value) where T : Grid {
        it.RowDefinitions.AddRange(value); // 190
        return it;
    }

    public static T RowDefinition<T>(this T it, RowDefinition value) where T : Grid {
        it.RowDefinitions.Add(value); // 190
        return it;
    }

    public static T Column<T>(this T it, int value) where T : Control {
        it.SetValue(Grid.ColumnProperty, value); // 2688
        return it;
    }

    public static T Row<T>(this T it, int value) where T : Control {
        it.SetValue(Grid.RowProperty, value); // 2705
        return it;
    }

    public static T ColumnSpan<T>(this T it, int value) where T : Control {
        it.SetValue(Grid.ColumnSpanProperty, value); // 2721
        return it;
    }
}
