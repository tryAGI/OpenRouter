
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputReasoningItemStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputReasoningItemStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputReasoningItemStatus2 value)
        {
            return value switch
            {
                OutputReasoningItemStatus2.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputReasoningItemStatus2? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => OutputReasoningItemStatus2.InProgress,
                _ => null,
            };
        }
    }
}