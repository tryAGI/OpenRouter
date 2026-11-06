
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemMcpCallErrorVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        McpToolExecutionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemMcpCallErrorVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemMcpCallErrorVariant3Type value)
        {
            return value switch
            {
                OutputItemMcpCallErrorVariant3Type.McpToolExecutionError => "mcp_tool_execution_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemMcpCallErrorVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_execution_error" => OutputItemMcpCallErrorVariant3Type.McpToolExecutionError,
                _ => null,
            };
        }
    }
}