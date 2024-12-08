using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace Avalonia.NoAxaml;

public static class TemplatedControlExtension {
    public static T FontWeight<T>(this T it, FontWeight value) where T : TemplatedControl {
        it.FontWeight = value; // 221
        return it;
    }
}
