
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.
    /// </summary>
    public enum WorkspaceBudgetInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Lifetime,
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
    public static class WorkspaceBudgetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceBudgetInterval value)
        {
            return value switch
            {
                WorkspaceBudgetInterval.Daily => "daily",
                WorkspaceBudgetInterval.Lifetime => "lifetime",
                WorkspaceBudgetInterval.Monthly => "monthly",
                WorkspaceBudgetInterval.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceBudgetInterval? ToEnum(string value)
        {
            return value switch
            {
                "daily" => WorkspaceBudgetInterval.Daily,
                "lifetime" => WorkspaceBudgetInterval.Lifetime,
                "monthly" => WorkspaceBudgetInterval.Monthly,
                "weekly" => WorkspaceBudgetInterval.Weekly,
                _ => null,
            };
        }
    }
}