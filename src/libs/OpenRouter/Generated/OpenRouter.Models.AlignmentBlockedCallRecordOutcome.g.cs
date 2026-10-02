
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AlignmentBlockedCallRecordOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlignmentBlockedCallRecordOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentBlockedCallRecordOutcome value)
        {
            return value switch
            {
                AlignmentBlockedCallRecordOutcome.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentBlockedCallRecordOutcome? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => AlignmentBlockedCallRecordOutcome.Blocked,
                _ => null,
            };
        }
    }
}