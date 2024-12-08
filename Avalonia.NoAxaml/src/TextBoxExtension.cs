using Avalonia.Controls;
using Avalonia.Media;

namespace Avalonia.NoAxaml;

public static class TextBoxExtension {
    public static T Text<T>(this T it, string? value) where T : TextBox {
        it.Text = value; // 594
        return it;
    }

    public static T Text<T>(this T it, IObservable<string?> value) where T : TextBox {
        it.Bind(TextBox.TextProperty, value); // 594
        return it;
    }

    public static T TextWrapping<T>(this T it, TextWrapping value) where T : TextBox {
        it.TextWrapping = value; // 727
        return it;
    }

    public static T OnTextChanged<T>(this T it, EventHandler<TextChangedEventArgs> value) where T : TextBox {
        it.TextChanged += value; // 856
        return it;
    }
}
