
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default Value: 24h
    /// </summary>
    public enum BatchSubmitBodyCompletionWindow
    {
        /// <summary>
        ///
        /// </summary>
        x24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchSubmitBodyCompletionWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchSubmitBodyCompletionWindow value)
        {
            return value switch
            {
                BatchSubmitBodyCompletionWindow.x24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchSubmitBodyCompletionWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => BatchSubmitBodyCompletionWindow.x24h,
                _ => null,
            };
        }
    }
}