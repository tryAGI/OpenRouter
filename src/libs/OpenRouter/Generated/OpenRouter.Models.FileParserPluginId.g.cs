
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileParserPluginId
    {
        /// <summary>
        /// 
        /// </summary>
        FileParser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileParserPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileParserPluginId value)
        {
            return value switch
            {
                FileParserPluginId.FileParser => "file-parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileParserPluginId? ToEnum(string value)
        {
            return value switch
            {
                "file-parser" => FileParserPluginId.FileParser,
                _ => null,
            };
        }
    }
}