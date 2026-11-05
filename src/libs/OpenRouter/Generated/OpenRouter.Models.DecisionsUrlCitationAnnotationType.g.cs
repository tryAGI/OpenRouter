
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsUrlCitationAnnotationType
    {
        /// <summary>
        ///
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsUrlCitationAnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsUrlCitationAnnotationType value)
        {
            return value switch
            {
                DecisionsUrlCitationAnnotationType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsUrlCitationAnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => DecisionsUrlCitationAnnotationType.UrlCitation,
                _ => null,
            };
        }
    }
}