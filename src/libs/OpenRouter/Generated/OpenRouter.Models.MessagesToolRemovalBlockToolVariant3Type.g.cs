
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesToolRemovalBlockToolVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        McpToolsetReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolRemovalBlockToolVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolRemovalBlockToolVariant3Type value)
        {
            return value switch
            {
                MessagesToolRemovalBlockToolVariant3Type.McpToolsetReference => "mcp_toolset_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolRemovalBlockToolVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "mcp_toolset_reference" => MessagesToolRemovalBlockToolVariant3Type.McpToolsetReference,
                _ => null,
            };
        }
    }
}