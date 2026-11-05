
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpCallFailedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpCallFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpCallFailedEventType value)
        {
            return value switch
            {
                McpCallFailedEventType.ResponseMcpCallFailed => "response.mcp_call.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpCallFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.failed" => McpCallFailedEventType.ResponseMcpCallFailed,
                _ => null,
            };
        }
    }
}