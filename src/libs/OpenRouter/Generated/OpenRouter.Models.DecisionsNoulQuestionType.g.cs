
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsNoulQuestionType
    {
        /// <summary>
        ///
        /// </summary>
        Noul,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsNoulQuestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsNoulQuestionType value)
        {
            return value switch
            {
                DecisionsNoulQuestionType.Noul => "noul",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsNoulQuestionType? ToEnum(string value)
        {
            return value switch
            {
                "noul" => DecisionsNoulQuestionType.Noul,
                _ => null,
            };
        }
    }
}