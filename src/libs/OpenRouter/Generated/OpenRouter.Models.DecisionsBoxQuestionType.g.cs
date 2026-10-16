
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsBoxQuestionType
    {
        /// <summary>
        ///
        /// </summary>
        Box,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsBoxQuestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsBoxQuestionType value)
        {
            return value switch
            {
                DecisionsBoxQuestionType.Box => "box",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsBoxQuestionType? ToEnum(string value)
        {
            return value switch
            {
                "box" => DecisionsBoxQuestionType.Box,
                _ => null,
            };
        }
    }
}