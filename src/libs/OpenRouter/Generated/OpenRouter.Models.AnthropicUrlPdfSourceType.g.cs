
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicUrlPdfSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicUrlPdfSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicUrlPdfSourceType value)
        {
            return value switch
            {
                AnthropicUrlPdfSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicUrlPdfSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => AnthropicUrlPdfSourceType.Url,
                _ => null,
            };
        }
    }
}