
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesToolSearchToolResultBlockType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolSearchToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolSearchToolResultBlockType value)
        {
            return value switch
            {
                MessagesToolSearchToolResultBlockType.ToolSearchToolResult => "tool_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolSearchToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_result" => MessagesToolSearchToolResultBlockType.ToolSearchToolResult,
                _ => null,
            };
        }
    }
}