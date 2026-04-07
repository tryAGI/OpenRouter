
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolCallStatus
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
    public static class ToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallStatus value)
        {
            return value switch
            {
                ToolCallStatus.Completed => "completed",
                ToolCallStatus.InProgress => "in_progress",
                ToolCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ToolCallStatus.Completed,
                "in_progress" => ToolCallStatus.InProgress,
                "incomplete" => ToolCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}