
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputToolSearchCallItemType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputToolSearchCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputToolSearchCallItemType value)
        {
            return value switch
            {
                OutputToolSearchCallItemType.ToolSearchCall => "tool_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputToolSearchCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_call" => OutputToolSearchCallItemType.ToolSearchCall,
                _ => null,
            };
        }
    }
}