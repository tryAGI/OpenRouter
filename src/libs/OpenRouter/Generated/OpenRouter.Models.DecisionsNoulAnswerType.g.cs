
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsNoulAnswerType
    {
        /// <summary>
        ///
        /// </summary>
        Noul,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsNoulAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsNoulAnswerType value)
        {
            return value switch
            {
                DecisionsNoulAnswerType.Noul => "noul",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsNoulAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "noul" => DecisionsNoulAnswerType.Noul,
                _ => null,
            };
        }
    }
}