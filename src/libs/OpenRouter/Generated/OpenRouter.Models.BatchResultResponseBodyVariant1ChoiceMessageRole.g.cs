
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchResultResponseBodyVariant1ChoiceMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant1ChoiceMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant1ChoiceMessageRole value)
        {
            return value switch
            {
                BatchResultResponseBodyVariant1ChoiceMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant1ChoiceMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BatchResultResponseBodyVariant1ChoiceMessageRole.Assistant,
                _ => null,
            };
        }
    }
}