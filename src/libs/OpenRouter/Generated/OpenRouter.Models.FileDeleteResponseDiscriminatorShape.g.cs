
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FileDeleteResponseDiscriminatorShape
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
        /// <summary>
        ///
        /// </summary>
        Openai,
        /// <summary>
        ///
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileDeleteResponseDiscriminatorShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileDeleteResponseDiscriminatorShape value)
        {
            return value switch
            {
                FileDeleteResponseDiscriminatorShape.Anthropic => "anthropic",
                FileDeleteResponseDiscriminatorShape.Openai => "openai",
                FileDeleteResponseDiscriminatorShape.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileDeleteResponseDiscriminatorShape? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => FileDeleteResponseDiscriminatorShape.Anthropic,
                "openai" => FileDeleteResponseDiscriminatorShape.Openai,
                "openrouter" => FileDeleteResponseDiscriminatorShape.Openrouter,
                _ => null,
            };
        }
    }
}