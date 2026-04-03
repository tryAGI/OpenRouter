
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCitationWebSearchResultLocationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCitationWebSearchResultLocationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCitationWebSearchResultLocationParamType value)
        {
            return value switch
            {
                AnthropicCitationWebSearchResultLocationParamType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCitationWebSearchResultLocationParamType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => AnthropicCitationWebSearchResultLocationParamType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}