
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentPartInputFileType
    {
        /// <summary>
        /// 
        /// </summary>
        InputFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentPartInputFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentPartInputFileType value)
        {
            return value switch
            {
                ContentPartInputFileType.InputFile => "input_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentPartInputFileType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => ContentPartInputFileType.InputFile,
                _ => null,
            };
        }
    }
}