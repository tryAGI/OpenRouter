
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemReasoningStatus1
    {
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemReasoningStatus1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemReasoningStatus1 value)
        {
            return value switch
            {
                OutputItemReasoningStatus1.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemReasoningStatus1? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => OutputItemReasoningStatus1.Incomplete,
                _ => null,
            };
        }
    }
}