
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpListToolsCompletedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpListToolsCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpListToolsCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpListToolsCompletedEventType value)
        {
            return value switch
            {
                McpListToolsCompletedEventType.ResponseMcpListToolsCompleted => "response.mcp_list_tools.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpListToolsCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_list_tools.completed" => McpListToolsCompletedEventType.ResponseMcpListToolsCompleted,
                _ => null,
            };
        }
    }
}