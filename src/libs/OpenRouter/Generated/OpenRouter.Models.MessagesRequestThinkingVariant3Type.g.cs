
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestThinkingVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Adaptive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestThinkingVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestThinkingVariant3Type value)
        {
            return value switch
            {
                MessagesRequestThinkingVariant3Type.Adaptive => "adaptive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestThinkingVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => MessagesRequestThinkingVariant3Type.Adaptive,
                _ => null,
            };
        }
    }
}