
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomToolCallItemType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolCallItemType value)
        {
            return value switch
            {
                CustomToolCallItemType.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => CustomToolCallItemType.CustomToolCall,
                _ => null,
            };
        }
    }
}