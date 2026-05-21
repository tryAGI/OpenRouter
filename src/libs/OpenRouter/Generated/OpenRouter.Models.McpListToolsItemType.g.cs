
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpListToolsItemType
    {
        /// <summary>
        /// 
        /// </summary>
        McpListTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpListToolsItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpListToolsItemType value)
        {
            return value switch
            {
                McpListToolsItemType.McpListTools => "mcp_list_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpListToolsItemType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools" => McpListToolsItemType.McpListTools,
                _ => null,
            };
        }
    }
}