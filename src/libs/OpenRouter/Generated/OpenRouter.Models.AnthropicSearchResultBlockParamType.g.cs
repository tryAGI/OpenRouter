
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicSearchResultBlockParamType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicSearchResultBlockParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicSearchResultBlockParamType value)
        {
            return value switch
            {
                AnthropicSearchResultBlockParamType.SearchResult => "search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicSearchResultBlockParamType? ToEnum(string value)
        {
            return value switch
            {
                "search_result" => AnthropicSearchResultBlockParamType.SearchResult,
                _ => null,
            };
        }
    }
}