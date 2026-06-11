
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Marketplace category group to filter by (e.g. `coding`). Only apps tagged with a subcategory inside this group are returned. Mutually combinable with `subcategory` — when both are supplied the `subcategory` must belong to the `category` group.
    /// </summary>
    public enum DatasetsAppRankingsGetParametersCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Coding,
        /// <summary>
        /// 
        /// </summary>
        Creative,
        /// <summary>
        /// 
        /// </summary>
        Entertainment,
        /// <summary>
        /// 
        /// </summary>
        Productivity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsAppRankingsGetParametersCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsAppRankingsGetParametersCategory value)
        {
            return value switch
            {
                DatasetsAppRankingsGetParametersCategory.Coding => "coding",
                DatasetsAppRankingsGetParametersCategory.Creative => "creative",
                DatasetsAppRankingsGetParametersCategory.Entertainment => "entertainment",
                DatasetsAppRankingsGetParametersCategory.Productivity => "productivity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsAppRankingsGetParametersCategory? ToEnum(string value)
        {
            return value switch
            {
                "coding" => DatasetsAppRankingsGetParametersCategory.Coding,
                "creative" => DatasetsAppRankingsGetParametersCategory.Creative,
                "entertainment" => DatasetsAppRankingsGetParametersCategory.Entertainment,
                "productivity" => DatasetsAppRankingsGetParametersCategory.Productivity,
                _ => null,
            };
        }
    }
}