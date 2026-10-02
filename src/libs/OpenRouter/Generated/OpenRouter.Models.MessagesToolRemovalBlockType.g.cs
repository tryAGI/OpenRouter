
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesToolRemovalBlockType
    {
        /// <summary>
        ///
        /// </summary>
        ToolRemoval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolRemovalBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolRemovalBlockType value)
        {
            return value switch
            {
                MessagesToolRemovalBlockType.ToolRemoval => "tool_removal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolRemovalBlockType? ToEnum(string value)
        {
            return value switch
            {
                "tool_removal" => MessagesToolRemovalBlockType.ToolRemoval,
                _ => null,
            };
        }
    }
}