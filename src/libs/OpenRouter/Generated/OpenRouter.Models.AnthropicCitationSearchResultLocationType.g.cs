
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCitationSearchResultLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCitationSearchResultLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCitationSearchResultLocationType value)
        {
            return value switch
            {
                AnthropicCitationSearchResultLocationType.SearchResultLocation => "search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCitationSearchResultLocationType? ToEnum(string value)
        {
            return value switch
            {
                "search_result_location" => AnthropicCitationSearchResultLocationType.SearchResultLocation,
                _ => null,
            };
        }
    }
}