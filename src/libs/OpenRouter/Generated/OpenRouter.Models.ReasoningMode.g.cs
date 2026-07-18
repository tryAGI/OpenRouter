
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Selects the reasoning mode. `standard` is the default; `pro` engages deeper reasoning on models that support it, billed at standard token rates. Only supported by OpenAI GPT-5.6 and newer.
    /// </summary>
    public enum ReasoningMode
    {
        /// <summary>
        /// 
        /// </summary>
        Pro,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningMode value)
        {
            return value switch
            {
                ReasoningMode.Pro => "pro",
                ReasoningMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningMode? ToEnum(string value)
        {
            return value switch
            {
                "pro" => ReasoningMode.Pro,
                "standard" => ReasoningMode.Standard,
                _ => null,
            };
        }
    }
}