
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Interval at which spend resets. Null means a lifetime (one-time) budget.
    /// </summary>
    public enum UpsertWorkspaceBudgetResponseDataResetInterval
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
    public static class UpsertWorkspaceBudgetResponseDataResetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertWorkspaceBudgetResponseDataResetInterval value)
        {
            return value switch
            {
                UpsertWorkspaceBudgetResponseDataResetInterval.Daily => "daily",
                UpsertWorkspaceBudgetResponseDataResetInterval.Monthly => "monthly",
                UpsertWorkspaceBudgetResponseDataResetInterval.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertWorkspaceBudgetResponseDataResetInterval? ToEnum(string value)
        {
            return value switch
            {
                "daily" => UpsertWorkspaceBudgetResponseDataResetInterval.Daily,
                "monthly" => UpsertWorkspaceBudgetResponseDataResetInterval.Monthly,
                "weekly" => UpsertWorkspaceBudgetResponseDataResetInterval.Weekly,
                _ => null,
            };
        }
    }
}