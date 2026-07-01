
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilesServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_files,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilesServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilesServerToolType value)
        {
            return value switch
            {
                FilesServerToolType.Openrouter_files => "openrouter:files",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilesServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:files" => FilesServerToolType.Openrouter_files,
                _ => null,
            };
        }
    }
}