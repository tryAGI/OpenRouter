
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenRouterFileDeletedShape
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenRouterFileDeletedShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenRouterFileDeletedShape value)
        {
            return value switch
            {
                OpenRouterFileDeletedShape.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenRouterFileDeletedShape? ToEnum(string value)
        {
            return value switch
            {
                "openrouter" => OpenRouterFileDeletedShape.Openrouter,
                _ => null,
            };
        }
    }
}