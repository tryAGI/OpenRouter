
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenRouterFileShape
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenRouterFileShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenRouterFileShape value)
        {
            return value switch
            {
                OpenRouterFileShape.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenRouterFileShape? ToEnum(string value)
        {
            return value switch
            {
                "openrouter" => OpenRouterFileShape.Openrouter,
                _ => null,
            };
        }
    }
}