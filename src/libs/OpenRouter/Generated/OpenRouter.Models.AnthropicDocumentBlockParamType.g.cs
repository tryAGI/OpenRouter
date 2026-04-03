
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicDocumentBlockParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicDocumentBlockParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicDocumentBlockParamType value)
        {
            return value switch
            {
                AnthropicDocumentBlockParamType.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicDocumentBlockParamType? ToEnum(string value)
        {
            return value switch
            {
                "document" => AnthropicDocumentBlockParamType.Document,
                _ => null,
            };
        }
    }
}