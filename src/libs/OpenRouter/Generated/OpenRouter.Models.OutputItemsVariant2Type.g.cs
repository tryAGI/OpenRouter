
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: computer_call
    /// </summary>
    public enum OutputItemsVariant2Type
    {
        /// <summary>
        /// computer_call
        /// </summary>
        ComputerCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant2Type value)
        {
            return value switch
            {
                OutputItemsVariant2Type.ComputerCall => "computer_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "computer_call" => OutputItemsVariant2Type.ComputerCall,
                _ => null,
            };
        }
    }
}