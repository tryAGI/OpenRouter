
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomToolCallOutputItemType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomToolCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolCallOutputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolCallOutputItemType value)
        {
            return value switch
            {
                CustomToolCallOutputItemType.CustomToolCallOutput => "custom_tool_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolCallOutputItemType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call_output" => CustomToolCallOutputItemType.CustomToolCallOutput,
                _ => null,
            };
        }
    }
}