
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: custom_tool_call
    /// </summary>
    public enum OutputItemsVariant4Type
    {
        /// <summary>
        /// custom_tool_call
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant4Type value)
        {
            return value switch
            {
                OutputItemsVariant4Type.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => OutputItemsVariant4Type.CustomToolCall,
                _ => null,
            };
        }
    }
}