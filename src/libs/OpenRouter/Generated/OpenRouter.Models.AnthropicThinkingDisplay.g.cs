
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicThinkingDisplay
    {
        /// <summary>
        /// 
        /// </summary>
        Omitted,
        /// <summary>
        /// 
        /// </summary>
        Summarized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkingDisplayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkingDisplay value)
        {
            return value switch
            {
                AnthropicThinkingDisplay.Omitted => "omitted",
                AnthropicThinkingDisplay.Summarized => "summarized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkingDisplay? ToEnum(string value)
        {
            return value switch
            {
                "omitted" => AnthropicThinkingDisplay.Omitted,
                "summarized" => AnthropicThinkingDisplay.Summarized,
                _ => null,
            };
        }
    }
}