
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum RequestCapacityEntryV2Variant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Concurrency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestCapacityEntryV2Variant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestCapacityEntryV2Variant3Type value)
        {
            return value switch
            {
                RequestCapacityEntryV2Variant3Type.Concurrency => "concurrency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestCapacityEntryV2Variant3Type? ToEnum(string value)
        {
            return value switch
            {
                "concurrency" => RequestCapacityEntryV2Variant3Type.Concurrency,
                _ => null,
            };
        }
    }
}