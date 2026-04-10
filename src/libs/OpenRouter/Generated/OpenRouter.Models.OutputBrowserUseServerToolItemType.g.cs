
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputBrowserUseServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_browserUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputBrowserUseServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputBrowserUseServerToolItemType value)
        {
            return value switch
            {
                OutputBrowserUseServerToolItemType.Openrouter_browserUse => "openrouter:browser_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputBrowserUseServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:browser_use" => OutputBrowserUseServerToolItemType.Openrouter_browserUse,
                _ => null,
            };
        }
    }
}