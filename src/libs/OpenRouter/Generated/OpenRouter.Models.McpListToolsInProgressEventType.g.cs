
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpListToolsInProgressEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpListToolsInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpListToolsInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpListToolsInProgressEventType value)
        {
            return value switch
            {
                McpListToolsInProgressEventType.ResponseMcpListToolsInProgress => "response.mcp_list_tools.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpListToolsInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_list_tools.in_progress" => McpListToolsInProgressEventType.ResponseMcpListToolsInProgress,
                _ => null,
            };
        }
    }
}