
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AlignmentAllowedCallRecordOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Allowed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlignmentAllowedCallRecordOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentAllowedCallRecordOutcome value)
        {
            return value switch
            {
                AlignmentAllowedCallRecordOutcome.Allowed => "allowed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentAllowedCallRecordOutcome? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => AlignmentAllowedCallRecordOutcome.Allowed,
                _ => null,
            };
        }
    }
}