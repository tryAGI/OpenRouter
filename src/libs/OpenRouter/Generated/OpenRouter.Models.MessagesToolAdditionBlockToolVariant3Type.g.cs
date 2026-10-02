
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesToolAdditionBlockToolVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        McpToolsetReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolAdditionBlockToolVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolAdditionBlockToolVariant3Type value)
        {
            return value switch
            {
                MessagesToolAdditionBlockToolVariant3Type.McpToolsetReference => "mcp_toolset_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolAdditionBlockToolVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "mcp_toolset_reference" => MessagesToolAdditionBlockToolVariant3Type.McpToolsetReference,
                _ => null,
            };
        }
    }
}