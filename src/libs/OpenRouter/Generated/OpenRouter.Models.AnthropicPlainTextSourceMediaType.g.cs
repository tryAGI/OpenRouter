
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicPlainTextSourceMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicPlainTextSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicPlainTextSourceMediaType value)
        {
            return value switch
            {
                AnthropicPlainTextSourceMediaType.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicPlainTextSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "text/plain" => AnthropicPlainTextSourceMediaType.TextPlain,
                _ => null,
            };
        }
    }
}