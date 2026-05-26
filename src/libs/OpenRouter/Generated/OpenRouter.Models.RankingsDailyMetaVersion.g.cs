
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Dataset version. Field names and grain are stable for the life of `v1`.
    /// </summary>
    public enum RankingsDailyMetaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RankingsDailyMetaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RankingsDailyMetaVersion value)
        {
            return value switch
            {
                RankingsDailyMetaVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RankingsDailyMetaVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => RankingsDailyMetaVersion.V1,
                _ => null,
            };
        }
    }
}