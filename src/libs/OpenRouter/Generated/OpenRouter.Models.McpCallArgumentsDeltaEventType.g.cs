
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpCallArgumentsDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpCallArgumentsDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpCallArgumentsDeltaEventType value)
        {
            return value switch
            {
                McpCallArgumentsDeltaEventType.ResponseMcpCallArgumentsDelta => "response.mcp_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpCallArgumentsDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call_arguments.delta" => McpCallArgumentsDeltaEventType.ResponseMcpCallArgumentsDelta,
                _ => null,
            };
        }
    }
}