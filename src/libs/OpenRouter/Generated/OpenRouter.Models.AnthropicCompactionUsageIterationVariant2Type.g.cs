
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicCompactionUsageIterationVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCompactionUsageIterationVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCompactionUsageIterationVariant2Type value)
        {
            return value switch
            {
                AnthropicCompactionUsageIterationVariant2Type.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCompactionUsageIterationVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => AnthropicCompactionUsageIterationVariant2Type.Compaction,
                _ => null,
            };
        }
    }
}