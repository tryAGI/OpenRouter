
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type value)
        {
            return value switch
            {
                BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type.UrlCitation,
                _ => null,
            };
        }
    }
}