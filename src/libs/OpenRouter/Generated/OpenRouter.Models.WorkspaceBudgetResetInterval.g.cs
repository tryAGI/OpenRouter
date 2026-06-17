
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Interval at which spend resets. Null means a lifetime (one-time) budget.
    /// </summary>
    public enum WorkspaceBudgetResetInterval
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
    public static class WorkspaceBudgetResetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceBudgetResetInterval value)
        {
            return value switch
            {
                WorkspaceBudgetResetInterval.Daily => "daily",
                WorkspaceBudgetResetInterval.Monthly => "monthly",
                WorkspaceBudgetResetInterval.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceBudgetResetInterval? ToEnum(string value)
        {
            return value switch
            {
                "daily" => WorkspaceBudgetResetInterval.Daily,
                "monthly" => WorkspaceBudgetResetInterval.Monthly,
                "weekly" => WorkspaceBudgetResetInterval.Weekly,
                _ => null,
            };
        }
    }
}