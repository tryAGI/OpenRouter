
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenRouterFileListShape
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenRouterFileListShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenRouterFileListShape value)
        {
            return value switch
            {
                OpenRouterFileListShape.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenRouterFileListShape? ToEnum(string value)
        {
            return value switch
            {
                "openrouter" => OpenRouterFileListShape.Openrouter,
                _ => null,
            };
        }
    }
}