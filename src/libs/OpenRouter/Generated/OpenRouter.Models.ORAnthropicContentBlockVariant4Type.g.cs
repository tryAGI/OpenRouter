
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: compaction
    /// </summary>
    public enum ORAnthropicContentBlockVariant4Type
    {
        /// <summary>
        /// compaction
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant4Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant4Type.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => ORAnthropicContentBlockVariant4Type.Compaction,
                _ => null,
            };
        }
    }
}