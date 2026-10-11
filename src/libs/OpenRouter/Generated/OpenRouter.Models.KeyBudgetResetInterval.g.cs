
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// UTC window the spend is counted over (weeks start Monday); null for a lifetime budget that never resets.<br/>
    /// Example: weekly
    /// </summary>
    public readonly partial struct KeyBudgetResetInterval : global::System.IEquatable<KeyBudgetResetInterval>
    {
        /// <summary>
        ///
        /// </summary>
        public KeyBudgetResetInterval(string value)
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
        public static KeyBudgetResetInterval Daily { get; } = new("daily");

        /// <summary>
        ///
        /// </summary>
        public static KeyBudgetResetInterval Monthly { get; } = new("monthly");

        /// <summary>
        ///
        /// </summary>
        public static KeyBudgetResetInterval Weekly { get; } = new("weekly");
        /// <summary>
        ///
        /// </summary>
        public static KeyBudgetResetInterval FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "daily" => Daily,
                "monthly" => Monthly,
                "weekly" => Weekly,
                _ => new KeyBudgetResetInterval(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "daily" => true,
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
        public bool Equals(KeyBudgetResetInterval other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KeyBudgetResetInterval other && Equals(other);
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
        public static bool operator ==(KeyBudgetResetInterval left, KeyBudgetResetInterval right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(KeyBudgetResetInterval left, KeyBudgetResetInterval right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyBudgetResetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyBudgetResetInterval value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyBudgetResetInterval? ToEnum(string value)
        {
            return KeyBudgetResetInterval.FromValue(value);
        }
    }
}