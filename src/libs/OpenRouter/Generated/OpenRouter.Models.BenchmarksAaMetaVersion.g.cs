
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Dataset version.
    /// </summary>
    public enum BenchmarksAaMetaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarksAaMetaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarksAaMetaVersion value)
        {
            return value switch
            {
                BenchmarksAaMetaVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarksAaMetaVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => BenchmarksAaMetaVersion.V1,
                _ => null,
            };
        }
    }
}