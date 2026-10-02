
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesToolRemovalBlockToolVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        McpToolReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolRemovalBlockToolVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolRemovalBlockToolVariant2Type value)
        {
            return value switch
            {
                MessagesToolRemovalBlockToolVariant2Type.McpToolReference => "mcp_tool_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolRemovalBlockToolVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_reference" => MessagesToolRemovalBlockToolVariant2Type.McpToolReference,
                _ => null,
            };
        }
    }
}