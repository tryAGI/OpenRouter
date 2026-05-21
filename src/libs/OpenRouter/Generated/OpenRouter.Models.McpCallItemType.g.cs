
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpCallItemType
    {
        /// <summary>
        /// 
        /// </summary>
        McpCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpCallItemType value)
        {
            return value switch
            {
                McpCallItemType.McpCall => "mcp_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_call" => McpCallItemType.McpCall,
                _ => null,
            };
        }
    }
}