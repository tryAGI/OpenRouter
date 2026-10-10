
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DeferredRegexSearchType
    {
        /// <summary>
        ///
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeferredRegexSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeferredRegexSearchType value)
        {
            return value switch
            {
                DeferredRegexSearchType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeferredRegexSearchType? ToEnum(string value)
        {
            return value switch
            {
                "regex" => DeferredRegexSearchType.Regex,
                _ => null,
            };
        }
    }
}