
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Dataset version.
    /// </summary>
    public enum UnifiedBenchmarksMetaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedBenchmarksMetaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksMetaVersion value)
        {
            return value switch
            {
                UnifiedBenchmarksMetaVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksMetaVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => UnifiedBenchmarksMetaVersion.V1,
                _ => null,
            };
        }
    }
}