
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ORAnthropicToolSearchResultType
    {
        /// <summary>
        ///
        /// </summary>
        OpenrouterToolSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicToolSearchResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicToolSearchResultType value)
        {
            return value switch
            {
                ORAnthropicToolSearchResultType.OpenrouterToolSearchResult => "openrouter_tool_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicToolSearchResultType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter_tool_search_result" => ORAnthropicToolSearchResultType.OpenrouterToolSearchResult,
                _ => null,
            };
        }
    }
}