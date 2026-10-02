
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchListItemCompletionWindow
    {
        /// <summary>
        ///
        /// </summary>
        x24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchListItemCompletionWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchListItemCompletionWindow value)
        {
            return value switch
            {
                BatchListItemCompletionWindow.x24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchListItemCompletionWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => BatchListItemCompletionWindow.x24h,
                _ => null,
            };
        }
    }
}