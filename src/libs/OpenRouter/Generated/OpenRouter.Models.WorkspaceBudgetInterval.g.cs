
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.<br/>
    /// Example: monthly
    /// </summary>
    public readonly partial struct WorkspaceBudgetInterval : global::System.IEquatable<WorkspaceBudgetInterval>
    {
        /// <summary>
        ///
        /// </summary>
        public WorkspaceBudgetInterval(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static WorkspaceBudgetInterval Daily { get; } = new("daily");

        /// <summary>
        ///
        /// </summary>
        public static WorkspaceBudgetInterval Lifetime { get; } = new("lifetime");

        /// <summary>
        ///
        /// </summary>
        public static WorkspaceBudgetInterval Monthly { get; } = new("monthly");

        /// <summary>
        ///
        /// </summary>
        public static WorkspaceBudgetInterval Weekly { get; } = new("weekly");
        /// <summary>
        ///
        /// </summary>
        public static WorkspaceBudgetInterval FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "daily" => Daily,
                "lifetime" => Lifetime,
                "monthly" => Monthly,
                "weekly" => Weekly,
                _ => new WorkspaceBudgetInterval(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "daily" => true,
            "lifetime" => true,
            "monthly" => true,
            "weekly" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(WorkspaceBudgetInterval other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkspaceBudgetInterval other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WorkspaceBudgetInterval left, WorkspaceBudgetInterval right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WorkspaceBudgetInterval left, WorkspaceBudgetInterval right) => !left.Equals(right);
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
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceBudgetInterval? ToEnum(string value)
        {
            return WorkspaceBudgetInterval.FromValue(value);
        }
    }
}