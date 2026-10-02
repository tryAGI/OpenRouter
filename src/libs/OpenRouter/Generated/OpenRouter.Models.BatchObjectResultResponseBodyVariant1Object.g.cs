
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchObjectResultResponseBodyVariant1Object
    {
        /// <summary>
        ///
        /// </summary>
        ChatCompletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectResultResponseBodyVariant1ObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectResultResponseBodyVariant1Object value)
        {
            return value switch
            {
                BatchObjectResultResponseBodyVariant1Object.ChatCompletion => "chat.completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectResultResponseBodyVariant1Object? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion" => BatchObjectResultResponseBodyVariant1Object.ChatCompletion,
                _ => null,
            };
        }
    }
}