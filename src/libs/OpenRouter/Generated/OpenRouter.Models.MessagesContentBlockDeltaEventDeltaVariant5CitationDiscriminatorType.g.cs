
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType
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
    public static class MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType value)
        {
            return value switch
            {
                MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.CharLocation => "char_location",
                MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.PageLocation => "page_location",
                MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.SearchResultLocation => "search_result_location",
                MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.CharLocation,
                "content_block_location" => MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.ContentBlockLocation,
                "page_location" => MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.PageLocation,
                "search_result_location" => MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.SearchResultLocation,
                "web_search_result_location" => MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}