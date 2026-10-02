
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchPaymentRequiredResponseCompletionWindow
    {
        /// <summary>
        ///
        /// </summary>
        x24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchPaymentRequiredResponseCompletionWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchPaymentRequiredResponseCompletionWindow value)
        {
            return value switch
            {
                BatchPaymentRequiredResponseCompletionWindow.x24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchPaymentRequiredResponseCompletionWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => BatchPaymentRequiredResponseCompletionWindow.x24h,
                _ => null,
            };
        }
    }
}