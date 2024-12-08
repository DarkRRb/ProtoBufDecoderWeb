using System;
using System.Linq;

namespace ProtoBufDecoderWeb;

public static class RangeUtil {
    public static bool IsWithinClosed<T>(this T value, T start, T end) where T : IComparable<T> {
        return 0 <= value.CompareTo(start) && value.CompareTo(end) <= 0;
    }

    public static bool IsWithinClosedAny<T>(this T value, params (T start, T end)[] ranges) where T : IComparable<T> {
        return ranges.Any(range => value.IsWithinClosed(range.start, range.end));
    }
}