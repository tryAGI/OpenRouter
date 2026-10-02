
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestThinkingVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestThinkingVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestThinkingVariant2Type value)
        {
            return value switch
            {
                MessagesRequestThinkingVariant2Type.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestThinkingVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => MessagesRequestThinkingVariant2Type.Disabled,
                _ => null,
            };
        }
    }
}