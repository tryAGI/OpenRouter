
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchPaymentRequiredResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        Batch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchPaymentRequiredResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchPaymentRequiredResponseObject value)
        {
            return value switch
            {
                BatchPaymentRequiredResponseObject.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchPaymentRequiredResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BatchPaymentRequiredResponseObject.Batch,
                _ => null,
            };
        }
    }
}