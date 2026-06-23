
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Trailing time window for the classification data. Currently only `7d` (trailing 7 days) is supported.<br/>
    /// Default Value: 7d
    /// </summary>
    public enum ClassificationsTaskGetParametersWindow
    {
        /// <summary>
        /// 
        /// </summary>
        x7d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassificationsTaskGetParametersWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassificationsTaskGetParametersWindow value)
        {
            return value switch
            {
                ClassificationsTaskGetParametersWindow.x7d => "7d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassificationsTaskGetParametersWindow? ToEnum(string value)
        {
            return value switch
            {
                "7d" => ClassificationsTaskGetParametersWindow.x7d,
                _ => null,
            };
        }
    }
}