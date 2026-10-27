
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesToolAdditionBlockToolVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        ToolDefinition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolAdditionBlockToolVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolAdditionBlockToolVariant4Type value)
        {
            return value switch
            {
                MessagesToolAdditionBlockToolVariant4Type.ToolDefinition => "tool_definition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolAdditionBlockToolVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_definition" => MessagesToolAdditionBlockToolVariant4Type.ToolDefinition,
                _ => null,
            };
        }
    }
}