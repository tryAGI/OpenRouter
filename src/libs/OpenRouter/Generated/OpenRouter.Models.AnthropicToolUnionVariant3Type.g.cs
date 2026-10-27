
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolUnionVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        TextEditor20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolUnionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolUnionVariant3Type value)
        {
            return value switch
            {
                AnthropicToolUnionVariant3Type.TextEditor20250124 => "text_editor_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolUnionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20250124" => AnthropicToolUnionVariant3Type.TextEditor20250124,
                _ => null,
            };
        }
    }
}