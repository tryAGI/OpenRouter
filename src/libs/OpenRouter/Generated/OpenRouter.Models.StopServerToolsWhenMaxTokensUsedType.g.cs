
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum StopServerToolsWhenMaxTokensUsedType
    {
        /// <summary>
        /// 
        /// </summary>
        MaxTokensUsed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopServerToolsWhenMaxTokensUsedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopServerToolsWhenMaxTokensUsedType value)
        {
            return value switch
            {
                StopServerToolsWhenMaxTokensUsedType.MaxTokensUsed => "max_tokens_used",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopServerToolsWhenMaxTokensUsedType? ToEnum(string value)
        {
            return value switch
            {
                "max_tokens_used" => StopServerToolsWhenMaxTokensUsedType.MaxTokensUsed,
                _ => null,
            };
        }
    }
}