
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputWebFetchServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_webFetch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputWebFetchServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputWebFetchServerToolItemType value)
        {
            return value switch
            {
                OutputWebFetchServerToolItemType.Openrouter_webFetch => "openrouter:web_fetch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputWebFetchServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:web_fetch" => OutputWebFetchServerToolItemType.Openrouter_webFetch,
                _ => null,
            };
        }
    }
}