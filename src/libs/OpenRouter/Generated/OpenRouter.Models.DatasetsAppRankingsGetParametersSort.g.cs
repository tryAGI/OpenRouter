
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// `popular` ranks apps by total token volume inside the date window. `trending` ranks apps by absolute excess token growth: window volume minus the average volume of the three equal-length periods immediately preceding the window. Apps with no excess growth are omitted from `trending` results.<br/>
    /// Default Value: popular
    /// </summary>
    public enum DatasetsAppRankingsGetParametersSort
    {
        /// <summary>
        /// window volume minus the average volume of the three equal-length periods immediately preceding the window. Apps with no excess growth are omitted from `trending` results.
        /// </summary>
        Popular,
        /// <summary>
        /// window volume minus the average volume of the three equal-length periods immediately preceding the window. Apps with no excess growth are omitted from `trending` results.
        /// </summary>
        Trending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsAppRankingsGetParametersSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsAppRankingsGetParametersSort value)
        {
            return value switch
            {
                DatasetsAppRankingsGetParametersSort.Popular => "popular",
                DatasetsAppRankingsGetParametersSort.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsAppRankingsGetParametersSort? ToEnum(string value)
        {
            return value switch
            {
                "popular" => DatasetsAppRankingsGetParametersSort.Popular,
                "trending" => DatasetsAppRankingsGetParametersSort.Trending,
                _ => null,
            };
        }
    }
}