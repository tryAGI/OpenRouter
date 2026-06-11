
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Dataset version.
    /// </summary>
    public enum BenchmarksDaMetaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarksDaMetaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarksDaMetaVersion value)
        {
            return value switch
            {
                BenchmarksDaMetaVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarksDaMetaVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => BenchmarksDaMetaVersion.V1,
                _ => null,
            };
        }
    }
}