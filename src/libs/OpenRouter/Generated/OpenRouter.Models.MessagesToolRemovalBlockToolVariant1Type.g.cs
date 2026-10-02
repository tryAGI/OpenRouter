
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesToolRemovalBlockToolVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        ToolReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolRemovalBlockToolVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolRemovalBlockToolVariant1Type value)
        {
            return value switch
            {
                MessagesToolRemovalBlockToolVariant1Type.ToolReference => "tool_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolRemovalBlockToolVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_reference" => MessagesToolRemovalBlockToolVariant1Type.ToolReference,
                _ => null,
            };
        }
    }
}