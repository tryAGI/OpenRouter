
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: web_search_result_location
    /// </summary>
    public enum AnthropicTextCitationVariant5Type
    {
        /// <summary>
        /// web_search_result_location
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextCitationVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextCitationVariant5Type value)
        {
            return value switch
            {
                AnthropicTextCitationVariant5Type.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextCitationVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => AnthropicTextCitationVariant5Type.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}