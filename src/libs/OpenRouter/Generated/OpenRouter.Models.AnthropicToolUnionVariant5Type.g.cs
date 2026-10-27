
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolUnionVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch20260209,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolUnionVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolUnionVariant5Type value)
        {
            return value switch
            {
                AnthropicToolUnionVariant5Type.WebSearch20260209 => "web_search_20260209",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolUnionVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_20260209" => AnthropicToolUnionVariant5Type.WebSearch20260209,
                _ => null,
            };
        }
    }
}