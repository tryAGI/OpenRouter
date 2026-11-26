
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type value)
        {
            return value switch
            {
                BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type.UrlCitation,
                _ => null,
            };
        }
    }
}