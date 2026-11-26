
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchResultResponseBodyVariant1ChoiceMessageImageType
    {
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant1ChoiceMessageImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant1ChoiceMessageImageType value)
        {
            return value switch
            {
                BatchResultResponseBodyVariant1ChoiceMessageImageType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant1ChoiceMessageImageType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => BatchResultResponseBodyVariant1ChoiceMessageImageType.ImageUrl,
                _ => null,
            };
        }
    }
}