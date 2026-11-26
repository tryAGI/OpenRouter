
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchResultResponseBodyVariant1Object
    {
        /// <summary>
        ///
        /// </summary>
        ChatCompletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant1ObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant1Object value)
        {
            return value switch
            {
                BatchResultResponseBodyVariant1Object.ChatCompletion => "chat.completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant1Object? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion" => BatchResultResponseBodyVariant1Object.ChatCompletion,
                _ => null,
            };
        }
    }
}