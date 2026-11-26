
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchResultResponseBodyVariant5AudioVariant2Format
    {
        /// <summary>
        ///
        /// </summary>
        Pcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant5AudioVariant2FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant5AudioVariant2Format value)
        {
            return value switch
            {
                BatchResultResponseBodyVariant5AudioVariant2Format.Pcm => "pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant5AudioVariant2Format? ToEnum(string value)
        {
            return value switch
            {
                "pcm" => BatchResultResponseBodyVariant5AudioVariant2Format.Pcm,
                _ => null,
            };
        }
    }
}