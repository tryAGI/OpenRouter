
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemVariant6Type
    {
        /// <summary>
        ///
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemVariant6Type value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemVariant6Type.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => MessagesMessageParamContentVariant2ItemVariant6Type.Thinking,
                _ => null,
            };
        }
    }
}