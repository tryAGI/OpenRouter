
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpToolExecutionErrorType
    {
        /// <summary>
        ///
        /// </summary>
        McpToolExecutionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpToolExecutionErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpToolExecutionErrorType value)
        {
            return value switch
            {
                McpToolExecutionErrorType.McpToolExecutionError => "mcp_tool_execution_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpToolExecutionErrorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_execution_error" => McpToolExecutionErrorType.McpToolExecutionError,
                _ => null,
            };
        }
    }
}