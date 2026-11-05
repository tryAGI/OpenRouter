
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsResponseAnswersDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Box,
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
        Refusal,
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsResponseAnswersDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsResponseAnswersDiscriminatorType value)
        {
            return value switch
            {
                DecisionsResponseAnswersDiscriminatorType.Box => "box",
                DecisionsResponseAnswersDiscriminatorType.Choice => "choice",
                DecisionsResponseAnswersDiscriminatorType.Noul => "noul",
                DecisionsResponseAnswersDiscriminatorType.Refusal => "refusal",
                DecisionsResponseAnswersDiscriminatorType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsResponseAnswersDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "box" => DecisionsResponseAnswersDiscriminatorType.Box,
                "choice" => DecisionsResponseAnswersDiscriminatorType.Choice,
                "noul" => DecisionsResponseAnswersDiscriminatorType.Noul,
                "refusal" => DecisionsResponseAnswersDiscriminatorType.Refusal,
                "score" => DecisionsResponseAnswersDiscriminatorType.Score,
                _ => null,
            };
        }
    }
}