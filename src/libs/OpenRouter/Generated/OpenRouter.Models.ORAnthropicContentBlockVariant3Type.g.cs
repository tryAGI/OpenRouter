
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: compaction
    /// </summary>
    public enum ORAnthropicContentBlockVariant3Type
    {
        /// <summary>
        /// compaction
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant3Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant3Type.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => ORAnthropicContentBlockVariant3Type.Compaction,
                _ => null,
            };
        }
    }
}