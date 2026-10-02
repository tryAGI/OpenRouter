
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatToolChoiceVariant1
    {
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatToolChoiceVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatToolChoiceVariant1 value)
        {
            return value switch
            {
                ChatToolChoiceVariant1.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatToolChoiceVariant1? ToEnum(string value)
        {
            return value switch
            {
                "none" => ChatToolChoiceVariant1.None,
                _ => null,
            };
        }
    }
}