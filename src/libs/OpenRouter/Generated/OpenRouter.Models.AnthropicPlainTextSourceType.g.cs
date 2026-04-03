
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicPlainTextSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicPlainTextSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicPlainTextSourceType value)
        {
            return value switch
            {
                AnthropicPlainTextSourceType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicPlainTextSourceType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AnthropicPlainTextSourceType.Text,
                _ => null,
            };
        }
    }
}