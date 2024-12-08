using System.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Templates;

namespace Avalonia.NoAxaml;

public static class ItemsControlExtension {
    public static T ItemsSource<T>(this T it, IEnumerable? value) where T : ItemsControl {
        it.ItemsSource = value; // 176
        return it;
    }

    public static T ItemsSource<T>(this T it, IObservable<IEnumerable?> value) where T : ItemsControl {
        it.Bind(ItemsControl.ItemsSourceProperty, value); // 176
        return it;
    }

    public static T ItemTemplate<T>(this T it, IDataTemplate? value) where T : ItemsControl {
        it.ItemTemplate = value; // 186
        return it;
    }
}
