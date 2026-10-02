
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemVariant7Type
    {
        /// <summary>
        ///
        /// </summary>
        RedactedThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemVariant7Type value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemVariant7Type.RedactedThinking => "redacted_thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => MessagesMessageParamContentVariant2ItemVariant7Type.RedactedThinking,
                _ => null,
            };
        }
    }
}