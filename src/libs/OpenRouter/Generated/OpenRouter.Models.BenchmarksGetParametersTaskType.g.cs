
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Filter results by task type. For Artificial Analysis, maps to the corresponding index. For Design Arena, maps to the matching category.
    /// </summary>
    public enum BenchmarksGetParametersTaskType
    {
        /// <summary>
        /// 
        /// </summary>
        Agentic,
        /// <summary>
        /// 
        /// </summary>
        Coding,
        /// <summary>
        /// 
        /// </summary>
        Intelligence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarksGetParametersTaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarksGetParametersTaskType value)
        {
            return value switch
            {
                BenchmarksGetParametersTaskType.Agentic => "agentic",
                BenchmarksGetParametersTaskType.Coding => "coding",
                BenchmarksGetParametersTaskType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarksGetParametersTaskType? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => BenchmarksGetParametersTaskType.Agentic,
                "coding" => BenchmarksGetParametersTaskType.Coding,
                "intelligence" => BenchmarksGetParametersTaskType.Intelligence,
                _ => null,
            };
        }
    }
}