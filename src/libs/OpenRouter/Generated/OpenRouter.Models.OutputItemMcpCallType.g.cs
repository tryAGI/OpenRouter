
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemMcpCallType
    {
        /// <summary>
        ///
        /// </summary>
        McpCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemMcpCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemMcpCallType value)
        {
            return value switch
            {
                OutputItemMcpCallType.McpCall => "mcp_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemMcpCallType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_call" => OutputItemMcpCallType.McpCall,
                _ => null,
            };
        }
    }
}