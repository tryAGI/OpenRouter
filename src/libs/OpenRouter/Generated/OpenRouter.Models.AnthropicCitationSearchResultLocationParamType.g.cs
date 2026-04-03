
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCitationSearchResultLocationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCitationSearchResultLocationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCitationSearchResultLocationParamType value)
        {
            return value switch
            {
                AnthropicCitationSearchResultLocationParamType.SearchResultLocation => "search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCitationSearchResultLocationParamType? ToEnum(string value)
        {
            return value switch
            {
                "search_result_location" => AnthropicCitationSearchResultLocationParamType.SearchResultLocation,
                _ => null,
            };
        }
    }
}