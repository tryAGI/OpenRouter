
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// How much context to retrieve per result. Defaults to medium (15000 chars). Applies to Exa and Parallel engines; ignored with native provider search and Firecrawl.
    /// </summary>
    public enum SearchQualityLevel
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchQualityLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchQualityLevel value)
        {
            return value switch
            {
                SearchQualityLevel.High => "high",
                SearchQualityLevel.Low => "low",
                SearchQualityLevel.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchQualityLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => SearchQualityLevel.High,
                "low" => SearchQualityLevel.Low,
                "medium" => SearchQualityLevel.Medium,
                _ => null,
            };
        }
    }
}