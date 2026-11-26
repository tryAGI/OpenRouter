
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        WebSearchCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant3Type value)
        {
            return value switch
            {
                BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant3Type.WebSearchCitation => "web_search_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_citation" => BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant3Type.WebSearchCitation,
                _ => null,
            };
        }
    }
}