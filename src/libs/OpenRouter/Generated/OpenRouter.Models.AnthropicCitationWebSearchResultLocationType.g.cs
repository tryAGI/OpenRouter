
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCitationWebSearchResultLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCitationWebSearchResultLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCitationWebSearchResultLocationType value)
        {
            return value switch
            {
                AnthropicCitationWebSearchResultLocationType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCitationWebSearchResultLocationType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => AnthropicCitationWebSearchResultLocationType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}