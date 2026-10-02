
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchObjectResultResponseBodyVariant1ChoiceMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectResultResponseBodyVariant1ChoiceMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectResultResponseBodyVariant1ChoiceMessageRole value)
        {
            return value switch
            {
                BatchObjectResultResponseBodyVariant1ChoiceMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectResultResponseBodyVariant1ChoiceMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BatchObjectResultResponseBodyVariant1ChoiceMessageRole.Assistant,
                _ => null,
            };
        }
    }
}