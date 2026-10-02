
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputFilesServerToolItemType
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter_files,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFilesServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFilesServerToolItemType value)
        {
            return value switch
            {
                OutputFilesServerToolItemType.Openrouter_files => "openrouter:files",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFilesServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:files" => OutputFilesServerToolItemType.Openrouter_files,
                _ => null,
            };
        }
    }
}