
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebFetchServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_webFetch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebFetchServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchServerToolType value)
        {
            return value switch
            {
                WebFetchServerToolType.Openrouter_webFetch => "openrouter:web_fetch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:web_fetch" => WebFetchServerToolType.Openrouter_webFetch,
                _ => null,
            };
        }
    }
}