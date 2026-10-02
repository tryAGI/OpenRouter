
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesToolAdditionBlockType
    {
        /// <summary>
        ///
        /// </summary>
        ToolAddition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolAdditionBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolAdditionBlockType value)
        {
            return value switch
            {
                MessagesToolAdditionBlockType.ToolAddition => "tool_addition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolAdditionBlockType? ToEnum(string value)
        {
            return value switch
            {
                "tool_addition" => MessagesToolAdditionBlockType.ToolAddition,
                _ => null,
            };
        }
    }
}