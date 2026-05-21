
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicTextBlockParamCitationsItemsDiscriminatorType
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
    public static class AnthropicTextBlockParamCitationsItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextBlockParamCitationsItemsDiscriminatorType value)
        {
            return value switch
            {
                AnthropicTextBlockParamCitationsItemsDiscriminatorType.CharLocation => "char_location",
                AnthropicTextBlockParamCitationsItemsDiscriminatorType.ContentBlockLocation => "content_block_location",
                AnthropicTextBlockParamCitationsItemsDiscriminatorType.PageLocation => "page_location",
                AnthropicTextBlockParamCitationsItemsDiscriminatorType.SearchResultLocation => "search_result_location",
                AnthropicTextBlockParamCitationsItemsDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextBlockParamCitationsItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => AnthropicTextBlockParamCitationsItemsDiscriminatorType.CharLocation,
                "content_block_location" => AnthropicTextBlockParamCitationsItemsDiscriminatorType.ContentBlockLocation,
                "page_location" => AnthropicTextBlockParamCitationsItemsDiscriminatorType.PageLocation,
                "search_result_location" => AnthropicTextBlockParamCitationsItemsDiscriminatorType.SearchResultLocation,
                "web_search_result_location" => AnthropicTextBlockParamCitationsItemsDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}