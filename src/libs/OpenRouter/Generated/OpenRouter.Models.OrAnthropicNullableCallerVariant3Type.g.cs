
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: direct
    /// </summary>
    public enum OrAnthropicNullableCallerVariant3Type
    {
        /// <summary>
        /// direct
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrAnthropicNullableCallerVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrAnthropicNullableCallerVariant3Type value)
        {
            return value switch
            {
                OrAnthropicNullableCallerVariant3Type.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrAnthropicNullableCallerVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "direct" => OrAnthropicNullableCallerVariant3Type.Direct,
                _ => null,
            };
        }
    }
}