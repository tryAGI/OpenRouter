
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptCacheBreakpointMode
    {
        /// <summary>
        /// 
        /// </summary>
        Explicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCacheBreakpointModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheBreakpointMode value)
        {
            return value switch
            {
                PromptCacheBreakpointMode.Explicit => "explicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheBreakpointMode? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => PromptCacheBreakpointMode.Explicit,
                _ => null,
            };
        }
    }
}