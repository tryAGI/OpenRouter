
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: direct
    /// </summary>
    public enum AnthropicCallerVariant3Type
    {
        /// <summary>
        /// direct
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCallerVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCallerVariant3Type value)
        {
            return value switch
            {
                AnthropicCallerVariant3Type.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCallerVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "direct" => AnthropicCallerVariant3Type.Direct,
                _ => null,
            };
        }
    }
}