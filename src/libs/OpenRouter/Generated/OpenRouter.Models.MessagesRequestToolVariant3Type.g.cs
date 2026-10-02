
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestToolVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        TextEditor20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolVariant3Type value)
        {
            return value switch
            {
                MessagesRequestToolVariant3Type.TextEditor20250124 => "text_editor_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20250124" => MessagesRequestToolVariant3Type.TextEditor20250124,
                _ => null,
            };
        }
    }
}