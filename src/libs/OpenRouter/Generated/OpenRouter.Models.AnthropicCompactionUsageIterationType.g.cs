
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCompactionUsageIterationType
    {
        /// <summary>
        /// 
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCompactionUsageIterationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCompactionUsageIterationType value)
        {
            return value switch
            {
                AnthropicCompactionUsageIterationType.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCompactionUsageIterationType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => AnthropicCompactionUsageIterationType.Compaction,
                _ => null,
            };
        }
    }
}