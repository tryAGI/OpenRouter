
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchDeletedObjectObject
    {
        /// <summary>
        ///
        /// </summary>
        Batch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchDeletedObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchDeletedObjectObject value)
        {
            return value switch
            {
                BatchDeletedObjectObject.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchDeletedObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BatchDeletedObjectObject.Batch,
                _ => null,
            };
        }
    }
}