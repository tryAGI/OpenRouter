
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemMcpListToolsType
    {
        /// <summary>
        ///
        /// </summary>
        McpListTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemMcpListToolsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemMcpListToolsType value)
        {
            return value switch
            {
                OutputItemMcpListToolsType.McpListTools => "mcp_list_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemMcpListToolsType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools" => OutputItemMcpListToolsType.McpListTools,
                _ => null,
            };
        }
    }
}