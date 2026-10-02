
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsScoreQuestionType
    {
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsScoreQuestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsScoreQuestionType value)
        {
            return value switch
            {
                DecisionsScoreQuestionType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsScoreQuestionType? ToEnum(string value)
        {
            return value switch
            {
                "score" => DecisionsScoreQuestionType.Score,
                _ => null,
            };
        }
    }
}