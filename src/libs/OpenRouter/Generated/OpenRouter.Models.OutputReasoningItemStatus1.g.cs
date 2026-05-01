
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputReasoningItemStatus1
    {
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputReasoningItemStatus1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputReasoningItemStatus1 value)
        {
            return value switch
            {
                OutputReasoningItemStatus1.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputReasoningItemStatus1? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => OutputReasoningItemStatus1.Incomplete,
                _ => null,
            };
        }
    }
}