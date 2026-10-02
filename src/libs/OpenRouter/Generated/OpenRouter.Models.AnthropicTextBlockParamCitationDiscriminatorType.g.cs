
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicTextBlockParamCitationDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        CharLocation,
        /// <summary>
        ///
        /// </summary>
        ContentBlockLocation,
        /// <summary>
        ///
        /// </summary>
        PageLocation,
        /// <summary>
        ///
        /// </summary>
        SearchResultLocation,
        /// <summary>
        ///
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextBlockParamCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextBlockParamCitationDiscriminatorType value)
        {
            return value switch
            {
                AnthropicTextBlockParamCitationDiscriminatorType.CharLocation => "char_location",
                AnthropicTextBlockParamCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                AnthropicTextBlockParamCitationDiscriminatorType.PageLocation => "page_location",
                AnthropicTextBlockParamCitationDiscriminatorType.SearchResultLocation => "search_result_location",
                AnthropicTextBlockParamCitationDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextBlockParamCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => AnthropicTextBlockParamCitationDiscriminatorType.CharLocation,
                "content_block_location" => AnthropicTextBlockParamCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => AnthropicTextBlockParamCitationDiscriminatorType.PageLocation,
                "search_result_location" => AnthropicTextBlockParamCitationDiscriminatorType.SearchResultLocation,
                "web_search_result_location" => AnthropicTextBlockParamCitationDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}