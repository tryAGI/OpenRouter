
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpCallInProgressEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpCallInProgressEventType value)
        {
            return value switch
            {
                McpCallInProgressEventType.ResponseMcpCallInProgress => "response.mcp_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.in_progress" => McpCallInProgressEventType.ResponseMcpCallInProgress,
                _ => null,
            };
        }
    }
}