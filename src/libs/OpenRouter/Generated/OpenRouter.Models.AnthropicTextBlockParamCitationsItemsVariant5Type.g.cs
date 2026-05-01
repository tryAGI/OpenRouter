
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: web_search_result_location
    /// </summary>
    public enum AnthropicTextBlockParamCitationsItemsVariant5Type
    {
        /// <summary>
        /// web_search_result_location
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextBlockParamCitationsItemsVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextBlockParamCitationsItemsVariant5Type value)
        {
            return value switch
            {
                AnthropicTextBlockParamCitationsItemsVariant5Type.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextBlockParamCitationsItemsVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => AnthropicTextBlockParamCitationsItemsVariant5Type.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}