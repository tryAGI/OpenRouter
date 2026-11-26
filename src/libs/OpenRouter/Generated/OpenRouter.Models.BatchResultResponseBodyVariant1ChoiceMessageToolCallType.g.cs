
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchResultResponseBodyVariant1ChoiceMessageToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant1ChoiceMessageToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant1ChoiceMessageToolCallType value)
        {
            return value switch
            {
                BatchResultResponseBodyVariant1ChoiceMessageToolCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant1ChoiceMessageToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => BatchResultResponseBodyVariant1ChoiceMessageToolCallType.Function,
                _ => null,
            };
        }
    }
}