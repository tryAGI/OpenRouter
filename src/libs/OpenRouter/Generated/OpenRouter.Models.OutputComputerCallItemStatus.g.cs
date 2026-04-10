
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputComputerCallItemStatus
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
    public static class OutputComputerCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputComputerCallItemStatus value)
        {
            return value switch
            {
                OutputComputerCallItemStatus.Completed => "completed",
                OutputComputerCallItemStatus.InProgress => "in_progress",
                OutputComputerCallItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputComputerCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputComputerCallItemStatus.Completed,
                "in_progress" => OutputComputerCallItemStatus.InProgress,
                "incomplete" => OutputComputerCallItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}