
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputCustomToolCallItemType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputCustomToolCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputCustomToolCallItemType value)
        {
            return value switch
            {
                OutputCustomToolCallItemType.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputCustomToolCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => OutputCustomToolCallItemType.CustomToolCall,
                _ => null,
            };
        }
    }
}