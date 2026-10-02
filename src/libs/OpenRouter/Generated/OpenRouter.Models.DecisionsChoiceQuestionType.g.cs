
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsChoiceQuestionType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsChoiceQuestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsChoiceQuestionType value)
        {
            return value switch
            {
                DecisionsChoiceQuestionType.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsChoiceQuestionType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => DecisionsChoiceQuestionType.Choice,
                _ => null,
            };
        }
    }
}