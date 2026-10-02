
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FileResponseDiscriminatorShape
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
    public static class FileResponseDiscriminatorShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileResponseDiscriminatorShape value)
        {
            return value switch
            {
                FileResponseDiscriminatorShape.Anthropic => "anthropic",
                FileResponseDiscriminatorShape.Openai => "openai",
                FileResponseDiscriminatorShape.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileResponseDiscriminatorShape? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => FileResponseDiscriminatorShape.Anthropic,
                "openai" => FileResponseDiscriminatorShape.Openai,
                "openrouter" => FileResponseDiscriminatorShape.Openrouter,
                _ => null,
            };
        }
    }
}