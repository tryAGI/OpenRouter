
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpProtocolErrorType
    {
        /// <summary>
        ///
        /// </summary>
        McpProtocolError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpProtocolErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpProtocolErrorType value)
        {
            return value switch
            {
                McpProtocolErrorType.McpProtocolError => "mcp_protocol_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpProtocolErrorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_protocol_error" => McpProtocolErrorType.McpProtocolError,
                _ => null,
            };
        }
    }
}