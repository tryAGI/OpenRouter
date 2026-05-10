
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicTextCitationDiscriminatorType
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
    public static class AnthropicTextCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextCitationDiscriminatorType value)
        {
            return value switch
            {
                AnthropicTextCitationDiscriminatorType.CharLocation => "char_location",
                AnthropicTextCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                AnthropicTextCitationDiscriminatorType.PageLocation => "page_location",
                AnthropicTextCitationDiscriminatorType.SearchResultLocation => "search_result_location",
                AnthropicTextCitationDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => AnthropicTextCitationDiscriminatorType.CharLocation,
                "content_block_location" => AnthropicTextCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => AnthropicTextCitationDiscriminatorType.PageLocation,
                "search_result_location" => AnthropicTextCitationDiscriminatorType.SearchResultLocation,
                "web_search_result_location" => AnthropicTextCitationDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}