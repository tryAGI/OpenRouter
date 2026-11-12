
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchObjectResultResponseBodyVariant5AudioVariant2Format
    {
        /// <summary>
        ///
        /// </summary>
        Pcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectResultResponseBodyVariant5AudioVariant2FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectResultResponseBodyVariant5AudioVariant2Format value)
        {
            return value switch
            {
                BatchObjectResultResponseBodyVariant5AudioVariant2Format.Pcm => "pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectResultResponseBodyVariant5AudioVariant2Format? ToEnum(string value)
        {
            return value switch
            {
                "pcm" => BatchObjectResultResponseBodyVariant5AudioVariant2Format.Pcm,
                _ => null,
            };
        }
    }
}