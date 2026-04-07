
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningSummaryVerbosity
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Concise,
        /// <summary>
        /// 
        /// </summary>
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningSummaryVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningSummaryVerbosity value)
        {
            return value switch
            {
                ReasoningSummaryVerbosity.Auto => "auto",
                ReasoningSummaryVerbosity.Concise => "concise",
                ReasoningSummaryVerbosity.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningSummaryVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ReasoningSummaryVerbosity.Auto,
                "concise" => ReasoningSummaryVerbosity.Concise,
                "detailed" => ReasoningSummaryVerbosity.Detailed,
                _ => null,
            };
        }
    }
}