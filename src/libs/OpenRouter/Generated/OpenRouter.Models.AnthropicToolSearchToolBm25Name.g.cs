
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolSearchToolBm25Name
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchToolBm25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolSearchToolBm25NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolSearchToolBm25Name value)
        {
            return value switch
            {
                AnthropicToolSearchToolBm25Name.ToolSearchToolBm25 => "tool_search_tool_bm25",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolSearchToolBm25Name? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_bm25" => AnthropicToolSearchToolBm25Name.ToolSearchToolBm25,
                _ => null,
            };
        }
    }
}