
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchListItemObject
    {
        /// <summary>
        ///
        /// </summary>
        Batch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchListItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchListItemObject value)
        {
            return value switch
            {
                BatchListItemObject.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchListItemObject? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BatchListItemObject.Batch,
                _ => null,
            };
        }
    }
}