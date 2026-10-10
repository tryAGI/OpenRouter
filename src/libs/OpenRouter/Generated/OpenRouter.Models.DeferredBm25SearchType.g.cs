
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DeferredBm25SearchType
    {
        /// <summary>
        ///
        /// </summary>
        Bm25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeferredBm25SearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeferredBm25SearchType value)
        {
            return value switch
            {
                DeferredBm25SearchType.Bm25 => "bm25",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeferredBm25SearchType? ToEnum(string value)
        {
            return value switch
            {
                "bm25" => DeferredBm25SearchType.Bm25,
                _ => null,
            };
        }
    }
}