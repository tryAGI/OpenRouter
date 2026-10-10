
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ORAnthropicToolSearchResultParamType
    {
        /// <summary>
        ///
        /// </summary>
        OpenrouterToolSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicToolSearchResultParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicToolSearchResultParamType value)
        {
            return value switch
            {
                ORAnthropicToolSearchResultParamType.OpenrouterToolSearchResult => "openrouter_tool_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicToolSearchResultParamType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter_tool_search_result" => ORAnthropicToolSearchResultParamType.OpenrouterToolSearchResult,
                _ => null,
            };
        }
    }
}