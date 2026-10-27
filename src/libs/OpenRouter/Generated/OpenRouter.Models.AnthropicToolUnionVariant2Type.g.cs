
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolUnionVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Bash20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolUnionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolUnionVariant2Type value)
        {
            return value switch
            {
                AnthropicToolUnionVariant2Type.Bash20250124 => "bash_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolUnionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_20250124" => AnthropicToolUnionVariant2Type.Bash20250124,
                _ => null,
            };
        }
    }
}