
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenRouterWebSearchServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_webSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenRouterWebSearchServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenRouterWebSearchServerToolType value)
        {
            return value switch
            {
                OpenRouterWebSearchServerToolType.Openrouter_webSearch => "openrouter:web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenRouterWebSearchServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:web_search" => OpenRouterWebSearchServerToolType.Openrouter_webSearch,
                _ => null,
            };
        }
    }
}