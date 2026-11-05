
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpCallArgumentsDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpCallArgumentsDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpCallArgumentsDoneEventType value)
        {
            return value switch
            {
                McpCallArgumentsDoneEventType.ResponseMcpCallArgumentsDone => "response.mcp_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpCallArgumentsDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call_arguments.done" => McpCallArgumentsDoneEventType.ResponseMcpCallArgumentsDone,
                _ => null,
            };
        }
    }
}