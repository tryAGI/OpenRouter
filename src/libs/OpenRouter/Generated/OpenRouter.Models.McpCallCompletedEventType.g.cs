
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpCallCompletedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpCallCompletedEventType value)
        {
            return value switch
            {
                McpCallCompletedEventType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.completed" => McpCallCompletedEventType.ResponseMcpCallCompleted,
                _ => null,
            };
        }
    }
}