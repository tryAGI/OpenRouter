
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemMcpCallErrorVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        McpProtocolError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemMcpCallErrorVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemMcpCallErrorVariant2Type value)
        {
            return value switch
            {
                OutputItemMcpCallErrorVariant2Type.McpProtocolError => "mcp_protocol_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemMcpCallErrorVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "mcp_protocol_error" => OutputItemMcpCallErrorVariant2Type.McpProtocolError,
                _ => null,
            };
        }
    }
}