
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesToolSearchToolSearchResultType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchToolSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolSearchToolSearchResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolSearchToolSearchResultType value)
        {
            return value switch
            {
                MessagesToolSearchToolSearchResultType.ToolSearchToolSearchResult => "tool_search_tool_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolSearchToolSearchResultType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_search_result" => MessagesToolSearchToolSearchResultType.ToolSearchToolSearchResult,
                _ => null,
            };
        }
    }
}