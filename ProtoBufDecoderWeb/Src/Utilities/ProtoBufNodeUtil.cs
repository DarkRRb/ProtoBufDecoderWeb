using System;
using System.Runtime.InteropServices.JavaScript;
using Avalonia.Controls;
using Avalonia.NoAxaml;
using NProtoBufDecoder;
using ProtoBufDecoderWeb.Resources;

namespace ProtoBufDecoderWeb.Utilities;

public static partial class ProtoBufNodeUtil {
    [JSImport("globalThis.window.navigator.clipboard.writeText")]
    private static partial void CopyText([JSMarshalAs<JSType.String>] string text);

    public static MenuItem[] CreateCopyMenuItems(this ProtoBufNode node) => node.WireType switch {
        WireType.VARINT => [
            CreateCopyMenuItem(SR.CopyInt64, $"{node.AsInt64()}"),
            CreateCopyMenuItem(SR.CopyUint64, $"{node.AsUint64()}"),
            CreateCopyMenuItem(SR.CopySint64, $"{node.AsSint64()}"),
        ],
        WireType.I64 => [
            CreateCopyMenuItem(SR.CopyFixed64, $"{node.AsFixed64()}"),
            CreateCopyMenuItem(SR.CopySfixed64, $"{node.AsSfixed64()}"),
            CreateCopyMenuItem(SR.CopyDouble, $"{node.AsDouble()}"),
        ],
        WireType.LEN => [
            CreateCopyMenuItem(SR.CopyString, node.AsString()),
            CreateCopyMenuItem(SR.CopyBytes, Convert.ToHexString(node.AsBytes().Span)),
        ],
        WireType.I32 => [
            CreateCopyMenuItem(SR.CopyFixed32, $"{node.AsFixed32()}"),
            CreateCopyMenuItem(SR.CopySfixed32, $"{node.AsSfixed32()}"),
            CreateCopyMenuItem(SR.CopyFloat, $"{node.AsFloat()}"),
        ],
        _ => [],
    };

    private static MenuItem CreateCopyMenuItem(string header, string text) => new MenuItem()
        .Header(header)
        .OnClick((_, _) => CopyText(text));
}