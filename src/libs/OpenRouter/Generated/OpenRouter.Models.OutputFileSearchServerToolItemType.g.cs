
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFileSearchServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_fileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFileSearchServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFileSearchServerToolItemType value)
        {
            return value switch
            {
                OutputFileSearchServerToolItemType.Openrouter_fileSearch => "openrouter:file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFileSearchServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:file_search" => OutputFileSearchServerToolItemType.Openrouter_fileSearch,
                _ => null,
            };
        }
    }
}