
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestThinkingVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        BetweenTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestThinkingVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestThinkingVariant4Type value)
        {
            return value switch
            {
                MessagesRequestThinkingVariant4Type.BetweenTools => "between_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestThinkingVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "between_tools" => MessagesRequestThinkingVariant4Type.BetweenTools,
                _ => null,
            };
        }
    }
}