
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FileListResponseDiscriminatorShape
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
    public static class FileListResponseDiscriminatorShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileListResponseDiscriminatorShape value)
        {
            return value switch
            {
                FileListResponseDiscriminatorShape.Anthropic => "anthropic",
                FileListResponseDiscriminatorShape.Openai => "openai",
                FileListResponseDiscriminatorShape.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileListResponseDiscriminatorShape? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => FileListResponseDiscriminatorShape.Anthropic,
                "openai" => FileListResponseDiscriminatorShape.Openai,
                "openrouter" => FileListResponseDiscriminatorShape.Openrouter,
                _ => null,
            };
        }
    }
}