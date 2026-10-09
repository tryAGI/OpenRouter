
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolSearchCallItemType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchCallItemType value)
        {
            return value switch
            {
                ToolSearchCallItemType.ToolSearchCall => "tool_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_call" => ToolSearchCallItemType.ToolSearchCall,
                _ => null,
            };
        }
    }
}