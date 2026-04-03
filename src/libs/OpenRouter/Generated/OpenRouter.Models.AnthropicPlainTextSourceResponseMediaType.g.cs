
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicPlainTextSourceResponseMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicPlainTextSourceResponseMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicPlainTextSourceResponseMediaType value)
        {
            return value switch
            {
                AnthropicPlainTextSourceResponseMediaType.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicPlainTextSourceResponseMediaType? ToEnum(string value)
        {
            return value switch
            {
                "text/plain" => AnthropicPlainTextSourceResponseMediaType.TextPlain,
                _ => null,
            };
        }
    }
}