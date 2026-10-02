
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AlignmentUnavailableCallRecordOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlignmentUnavailableCallRecordOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentUnavailableCallRecordOutcome value)
        {
            return value switch
            {
                AlignmentUnavailableCallRecordOutcome.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentUnavailableCallRecordOutcome? ToEnum(string value)
        {
            return value switch
            {
                "unavailable" => AlignmentUnavailableCallRecordOutcome.Unavailable,
                _ => null,
            };
        }
    }
}