using Avalonia.Input;

namespace Avalonia.NoAxaml;

public static class InputElementExtension {
    public static T IsEnabled<T>(this T it, bool value) where T : InputElement {
        it.IsEnabled = value; // 398
        return it;
    }

    public static T IsEnabled<T>(this T it, IObservable<bool> value) where T : InputElement {
        it.Bind(InputElement.IsEnabledProperty, value); // 398
        return it;
    }
}
