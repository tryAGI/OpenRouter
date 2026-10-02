
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestToolChoiceVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolChoiceVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolChoiceVariant2Type value)
        {
            return value switch
            {
                MessagesRequestToolChoiceVariant2Type.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolChoiceVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "any" => MessagesRequestToolChoiceVariant2Type.Any,
                _ => null,
            };
        }
    }
}