
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicInputTokensClearAtLeastType
    {
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicInputTokensClearAtLeastTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicInputTokensClearAtLeastType value)
        {
            return value switch
            {
                AnthropicInputTokensClearAtLeastType.InputTokens => "input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicInputTokensClearAtLeastType? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => AnthropicInputTokensClearAtLeastType.InputTokens,
                _ => null,
            };
        }
    }
}