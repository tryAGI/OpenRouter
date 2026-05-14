
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: direct
    /// </summary>
    public enum ORAnthropicNullableCallerVariant3Type
    {
        /// <summary>
        /// direct
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicNullableCallerVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicNullableCallerVariant3Type value)
        {
            return value switch
            {
                ORAnthropicNullableCallerVariant3Type.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicNullableCallerVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "direct" => ORAnthropicNullableCallerVariant3Type.Direct,
                _ => null,
            };
        }
    }
}