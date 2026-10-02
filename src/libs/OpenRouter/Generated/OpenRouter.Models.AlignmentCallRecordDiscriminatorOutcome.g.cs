
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AlignmentCallRecordDiscriminatorOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Allowed,
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlignmentCallRecordDiscriminatorOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentCallRecordDiscriminatorOutcome value)
        {
            return value switch
            {
                AlignmentCallRecordDiscriminatorOutcome.Allowed => "allowed",
                AlignmentCallRecordDiscriminatorOutcome.Blocked => "blocked",
                AlignmentCallRecordDiscriminatorOutcome.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentCallRecordDiscriminatorOutcome? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => AlignmentCallRecordDiscriminatorOutcome.Allowed,
                "blocked" => AlignmentCallRecordDiscriminatorOutcome.Blocked,
                "unavailable" => AlignmentCallRecordDiscriminatorOutcome.Unavailable,
                _ => null,
            };
        }
    }
}