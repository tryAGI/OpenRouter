
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsBoxAnswerType
    {
        /// <summary>
        ///
        /// </summary>
        Box,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsBoxAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsBoxAnswerType value)
        {
            return value switch
            {
                DecisionsBoxAnswerType.Box => "box",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsBoxAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "box" => DecisionsBoxAnswerType.Box,
                _ => null,
            };
        }
    }
}