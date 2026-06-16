
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Status of a shell call or its output.
    /// </summary>
    public enum ShellCallStatus
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
    public static class ShellCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellCallStatus value)
        {
            return value switch
            {
                ShellCallStatus.Completed => "completed",
                ShellCallStatus.InProgress => "in_progress",
                ShellCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ShellCallStatus.Completed,
                "in_progress" => ShellCallStatus.InProgress,
                "incomplete" => ShellCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}