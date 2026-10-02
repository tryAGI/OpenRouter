
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2Type value)
        {
            return value switch
            {
                BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}