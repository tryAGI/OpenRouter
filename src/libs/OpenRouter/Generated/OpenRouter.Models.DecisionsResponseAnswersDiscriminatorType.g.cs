
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
    public static class DecisionsResponseAnswersDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsResponseAnswersDiscriminatorType value)
        {
            return value switch
            {
                DecisionsResponseAnswersDiscriminatorType.Choice => "choice",
                DecisionsResponseAnswersDiscriminatorType.Noul => "noul",
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
                "choice" => DecisionsResponseAnswersDiscriminatorType.Choice,
                "noul" => DecisionsResponseAnswersDiscriminatorType.Noul,
                "score" => DecisionsResponseAnswersDiscriminatorType.Score,
                _ => null,
            };
        }
    }
}