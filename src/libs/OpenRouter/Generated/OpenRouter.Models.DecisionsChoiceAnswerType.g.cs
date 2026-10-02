
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsChoiceAnswerType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsChoiceAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsChoiceAnswerType value)
        {
            return value switch
            {
                DecisionsChoiceAnswerType.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsChoiceAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => DecisionsChoiceAnswerType.Choice,
                _ => null,
            };
        }
    }
}