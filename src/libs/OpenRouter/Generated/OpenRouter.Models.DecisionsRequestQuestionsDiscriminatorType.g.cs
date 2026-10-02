
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsRequestQuestionsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
        /// <summary>
        ///
        /// </summary>
        Noul,
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsRequestQuestionsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsRequestQuestionsDiscriminatorType value)
        {
            return value switch
            {
                DecisionsRequestQuestionsDiscriminatorType.Choice => "choice",
                DecisionsRequestQuestionsDiscriminatorType.Noul => "noul",
                DecisionsRequestQuestionsDiscriminatorType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsRequestQuestionsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => DecisionsRequestQuestionsDiscriminatorType.Choice,
                "noul" => DecisionsRequestQuestionsDiscriminatorType.Noul,
                "score" => DecisionsRequestQuestionsDiscriminatorType.Score,
                _ => null,
            };
        }
    }
}