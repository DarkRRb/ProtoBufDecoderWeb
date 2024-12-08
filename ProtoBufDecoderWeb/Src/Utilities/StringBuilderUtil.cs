using System.Text;
using NProtoBufDecoder;

namespace ProtoBufDecoderWeb;

public static class StringBuilderUtil {
    public static StringBuilder AppendProtoBufNode(this StringBuilder builder, ProtoBufNode node) {
        return node.WireType switch {
            WireType.VARINT => builder.AppendFormat(
                "int64 {0} uint64 {1} sint64 {2}",
                node.AsInt64(),
                node.AsUint64(),
                node.AsSint64()
            ),
            WireType.I64 => builder.AppendFormat(
                "fixed64 {0} sfixed64 {1} double {2}",
                node.AsFixed64(),
                node.AsSfixed64(),
                node.AsDouble()
            ),
            WireType.LEN => !node.TryAsMessage(out _) && node.TryAsString(out string? @string)
                ? builder.AppendFormat("string {0}", @string)
                : builder,
            WireType.I32 => builder.AppendFormat(
                "fixed32 {0} sfixed32 {1} float {2}",
                node.AsFixed32(),
                node.AsSfixed32(),
                node.AsFloat()
            ),
            _ => builder,
        };
    }
}