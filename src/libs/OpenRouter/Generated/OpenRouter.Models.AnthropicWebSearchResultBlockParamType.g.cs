
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicWebSearchResultBlockParamType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebSearchResultBlockParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebSearchResultBlockParamType value)
        {
            return value switch
            {
                AnthropicWebSearchResultBlockParamType.WebSearchResult => "web_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebSearchResultBlockParamType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result" => AnthropicWebSearchResultBlockParamType.WebSearchResult,
                _ => null,
            };
        }
    }
}