
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Interval at which the limit resets (daily, weekly, monthly)
    /// </summary>
    public enum GuardrailInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailInterval value)
        {
            return value switch
            {
                GuardrailInterval.Daily => "daily",
                GuardrailInterval.Monthly => "monthly",
                GuardrailInterval.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailInterval? ToEnum(string value)
        {
            return value switch
            {
                "daily" => GuardrailInterval.Daily,
                "monthly" => GuardrailInterval.Monthly,
                "weekly" => GuardrailInterval.Weekly,
                _ => null,
            };
        }
    }
}