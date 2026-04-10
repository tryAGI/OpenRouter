
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputComputerCallItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputComputerCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputComputerCallItemType value)
        {
            return value switch
            {
                OutputComputerCallItemType.ComputerCall => "computer_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputComputerCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call" => OutputComputerCallItemType.ComputerCall,
                _ => null,
            };
        }
    }
}