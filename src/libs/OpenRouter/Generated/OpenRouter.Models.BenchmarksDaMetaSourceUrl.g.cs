
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// URL of the upstream data source.
    /// </summary>
    public enum BenchmarksDaMetaSourceUrl
    {
        /// <summary>
        /// 
        /// </summary>
        Https_WwwDesignarenaAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarksDaMetaSourceUrlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarksDaMetaSourceUrl value)
        {
            return value switch
            {
                BenchmarksDaMetaSourceUrl.Https_WwwDesignarenaAi => "https://www.designarena.ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarksDaMetaSourceUrl? ToEnum(string value)
        {
            return value switch
            {
                "https://www.designarena.ai" => BenchmarksDaMetaSourceUrl.Https_WwwDesignarenaAi,
                _ => null,
            };
        }
    }
}