
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// URL of the upstream data source.
    /// </summary>
    public enum BenchmarksAaMetaSourceUrl
    {
        /// <summary>
        /// 
        /// </summary>
        Https_ArtificialanalysisAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarksAaMetaSourceUrlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarksAaMetaSourceUrl value)
        {
            return value switch
            {
                BenchmarksAaMetaSourceUrl.Https_ArtificialanalysisAi => "https://artificialanalysis.ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarksAaMetaSourceUrl? ToEnum(string value)
        {
            return value switch
            {
                "https://artificialanalysis.ai" => BenchmarksAaMetaSourceUrl.Https_ArtificialanalysisAi,
                _ => null,
            };
        }
    }
}