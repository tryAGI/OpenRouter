
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchUserLocationServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchUserLocationServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchUserLocationServerToolType value)
        {
            return value switch
            {
                WebSearchUserLocationServerToolType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchUserLocationServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => WebSearchUserLocationServerToolType.Approximate,
                _ => null,
            };
        }
    }
}