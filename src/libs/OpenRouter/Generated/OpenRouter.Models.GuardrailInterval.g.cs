
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Interval at which the limit resets (daily, weekly, monthly)<br/>
    /// Example: monthly
    /// </summary>
    public readonly partial struct GuardrailInterval : global::System.IEquatable<GuardrailInterval>
    {
        /// <summary>
        ///
        /// </summary>
        public GuardrailInterval(string value)
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
        public static GuardrailInterval Daily { get; } = new("daily");

        /// <summary>
        ///
        /// </summary>
        public static GuardrailInterval Monthly { get; } = new("monthly");

        /// <summary>
        ///
        /// </summary>
        public static GuardrailInterval Weekly { get; } = new("weekly");
        /// <summary>
        ///
        /// </summary>
        public static GuardrailInterval FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "daily" => Daily,
                "monthly" => Monthly,
                "weekly" => Weekly,
                _ => new GuardrailInterval(value),
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
        public bool Equals(GuardrailInterval other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GuardrailInterval other && Equals(other);
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
        public static bool operator ==(GuardrailInterval left, GuardrailInterval right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GuardrailInterval left, GuardrailInterval right) => !left.Equals(right);
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
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailInterval? ToEnum(string value)
        {
            return GuardrailInterval.FromValue(value);
        }
    }
}