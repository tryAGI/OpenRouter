
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpListToolsFailedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpListToolsFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpListToolsFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpListToolsFailedEventType value)
        {
            return value switch
            {
                McpListToolsFailedEventType.ResponseMcpListToolsFailed => "response.mcp_list_tools.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpListToolsFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_list_tools.failed" => McpListToolsFailedEventType.ResponseMcpListToolsFailed,
                _ => null,
            };
        }
    }
}