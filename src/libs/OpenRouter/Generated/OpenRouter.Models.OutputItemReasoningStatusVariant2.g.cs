
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemReasoningStatusVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemReasoningStatusVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemReasoningStatusVariant2 value)
        {
            return value switch
            {
                OutputItemReasoningStatusVariant2.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemReasoningStatusVariant2? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => OutputItemReasoningStatusVariant2.Incomplete,
                _ => null,
            };
        }
    }
}