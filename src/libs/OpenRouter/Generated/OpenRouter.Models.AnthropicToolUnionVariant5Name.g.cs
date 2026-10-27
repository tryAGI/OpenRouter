
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolUnionVariant5Name
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolUnionVariant5NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolUnionVariant5Name value)
        {
            return value switch
            {
                AnthropicToolUnionVariant5Name.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolUnionVariant5Name? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => AnthropicToolUnionVariant5Name.WebSearch,
                _ => null,
            };
        }
    }
}