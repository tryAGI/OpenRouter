
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicPlainTextSourceResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicPlainTextSourceResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicPlainTextSourceResponseType value)
        {
            return value switch
            {
                AnthropicPlainTextSourceResponseType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicPlainTextSourceResponseType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AnthropicPlainTextSourceResponseType.Text,
                _ => null,
            };
        }
    }
}