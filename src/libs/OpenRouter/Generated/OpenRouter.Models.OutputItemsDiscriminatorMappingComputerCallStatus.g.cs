
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemsDiscriminatorMappingComputerCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsDiscriminatorMappingComputerCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsDiscriminatorMappingComputerCallStatus value)
        {
            return value switch
            {
                OutputItemsDiscriminatorMappingComputerCallStatus.Completed => "completed",
                OutputItemsDiscriminatorMappingComputerCallStatus.InProgress => "in_progress",
                OutputItemsDiscriminatorMappingComputerCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsDiscriminatorMappingComputerCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputItemsDiscriminatorMappingComputerCallStatus.Completed,
                "in_progress" => OutputItemsDiscriminatorMappingComputerCallStatus.InProgress,
                "incomplete" => OutputItemsDiscriminatorMappingComputerCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}