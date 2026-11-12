
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchObjectResultResponseBodyVariant5AudioVariant1Format
    {
        /// <summary>
        ///
        /// </summary>
        Pcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectResultResponseBodyVariant5AudioVariant1FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectResultResponseBodyVariant5AudioVariant1Format value)
        {
            return value switch
            {
                BatchObjectResultResponseBodyVariant5AudioVariant1Format.Pcm => "pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectResultResponseBodyVariant5AudioVariant1Format? ToEnum(string value)
        {
            return value switch
            {
                "pcm" => BatchObjectResultResponseBodyVariant5AudioVariant1Format.Pcm,
                _ => null,
            };
        }
    }
}