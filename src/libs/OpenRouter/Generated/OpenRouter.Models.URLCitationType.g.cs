
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum URLCitationType
    {
        /// <summary>
        ///
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class URLCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this URLCitationType value)
        {
            return value switch
            {
                URLCitationType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static URLCitationType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => URLCitationType.UrlCitation,
                _ => null,
            };
        }
    }
}