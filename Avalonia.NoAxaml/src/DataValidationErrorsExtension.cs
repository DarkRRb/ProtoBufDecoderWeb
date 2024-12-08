using Avalonia.Controls;

namespace Avalonia.NoAxaml;

public static class DataValidationErrorsExtension {
    public static T Error<T>(this T it, params object[]? value) where T : Control {
        it.SetValue(DataValidationErrors.ErrorsProperty, value); // 26
        return it;
    }
}
