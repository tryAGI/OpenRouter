
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatToolChoiceVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatToolChoiceVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatToolChoiceVariant3 value)
        {
            return value switch
            {
                ChatToolChoiceVariant3.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatToolChoiceVariant3? ToEnum(string value)
        {
            return value switch
            {
                "required" => ChatToolChoiceVariant3.Required,
                _ => null,
            };
        }
    }
}