
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestToolVariant3Name
    {
        /// <summary>
        ///
        /// </summary>
        StrReplaceEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolVariant3NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolVariant3Name value)
        {
            return value switch
            {
                MessagesRequestToolVariant3Name.StrReplaceEditor => "str_replace_editor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolVariant3Name? ToEnum(string value)
        {
            return value switch
            {
                "str_replace_editor" => MessagesRequestToolVariant3Name.StrReplaceEditor,
                _ => null,
            };
        }
    }
}