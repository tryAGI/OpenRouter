
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicDocumentBlockParamSourceType
    {
        /// <summary>
        ///
        /// </summary>
        Content,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicDocumentBlockParamSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicDocumentBlockParamSourceType value)
        {
            return value switch
            {
                AnthropicDocumentBlockParamSourceType.Content => "content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicDocumentBlockParamSourceType? ToEnum(string value)
        {
            return value switch
            {
                "content" => AnthropicDocumentBlockParamSourceType.Content,
                _ => null,
            };
        }
    }
}