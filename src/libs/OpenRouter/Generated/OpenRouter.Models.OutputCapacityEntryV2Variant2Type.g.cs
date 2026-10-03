
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputCapacityEntryV2Variant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Concurrency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputCapacityEntryV2Variant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputCapacityEntryV2Variant2Type value)
        {
            return value switch
            {
                OutputCapacityEntryV2Variant2Type.Concurrency => "concurrency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputCapacityEntryV2Variant2Type? ToEnum(string value)
        {
            return value switch
            {
                "concurrency" => OutputCapacityEntryV2Variant2Type.Concurrency,
                _ => null,
            };
        }
    }
}