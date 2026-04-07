
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicWebFetchBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebFetchBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebFetchBlockType value)
        {
            return value switch
            {
                AnthropicWebFetchBlockType.WebFetchResult => "web_fetch_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebFetchBlockType? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_result" => AnthropicWebFetchBlockType.WebFetchResult,
                _ => null,
            };
        }
    }
}