
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicDocumentBlockParamSourceOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Content,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicDocumentBlockParamSourceOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicDocumentBlockParamSourceOneOf2Type value)
        {
            return value switch
            {
                AnthropicDocumentBlockParamSourceOneOf2Type.Content => "content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicDocumentBlockParamSourceOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "content" => AnthropicDocumentBlockParamSourceOneOf2Type.Content,
                _ => null,
            };
        }
    }
}