
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicMessagesErrorResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicMessagesErrorResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicMessagesErrorResponseType value)
        {
            return value switch
            {
                AnthropicMessagesErrorResponseType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicMessagesErrorResponseType? ToEnum(string value)
        {
            return value switch
            {
                "error" => AnthropicMessagesErrorResponseType.Error,
                _ => null,
            };
        }
    }
}