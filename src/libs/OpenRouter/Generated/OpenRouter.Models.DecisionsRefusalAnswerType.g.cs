
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsRefusalAnswerType
    {
        /// <summary>
        ///
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsRefusalAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsRefusalAnswerType value)
        {
            return value switch
            {
                DecisionsRefusalAnswerType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsRefusalAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => DecisionsRefusalAnswerType.Refusal,
                _ => null,
            };
        }
    }
}