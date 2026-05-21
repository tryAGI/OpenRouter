
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: computer_call
    /// </summary>
    public enum OutputItemsVariant3Type
    {
        /// <summary>
        /// computer_call
        /// </summary>
        ComputerCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant3Type value)
        {
            return value switch
            {
                OutputItemsVariant3Type.ComputerCall => "computer_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "computer_call" => OutputItemsVariant3Type.ComputerCall,
                _ => null,
            };
        }
    }
}