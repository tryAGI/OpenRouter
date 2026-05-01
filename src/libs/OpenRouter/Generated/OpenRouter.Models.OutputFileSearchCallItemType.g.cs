
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFileSearchCallItemType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFileSearchCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFileSearchCallItemType value)
        {
            return value switch
            {
                OutputFileSearchCallItemType.FileSearchCall => "file_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFileSearchCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "file_search_call" => OutputFileSearchCallItemType.FileSearchCall,
                _ => null,
            };
        }
    }
}