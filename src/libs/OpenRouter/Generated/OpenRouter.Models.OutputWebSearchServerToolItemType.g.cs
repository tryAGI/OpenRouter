
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputWebSearchServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_webSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputWebSearchServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputWebSearchServerToolItemType value)
        {
            return value switch
            {
                OutputWebSearchServerToolItemType.Openrouter_webSearch => "openrouter:web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputWebSearchServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:web_search" => OutputWebSearchServerToolItemType.Openrouter_webSearch,
                _ => null,
            };
        }
    }
}