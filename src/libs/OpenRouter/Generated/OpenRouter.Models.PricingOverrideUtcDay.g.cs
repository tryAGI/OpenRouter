
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PricingOverrideUtcDay : global::System.IEquatable<PricingOverrideUtcDay>
    {
        /// <summary>
        ///
        /// </summary>
        public PricingOverrideUtcDay(string value)
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
        public static PricingOverrideUtcDay Friday { get; } = new("friday");

        /// <summary>
        ///
        /// </summary>
        public static PricingOverrideUtcDay Monday { get; } = new("monday");

        /// <summary>
        ///
        /// </summary>
        public static PricingOverrideUtcDay Saturday { get; } = new("saturday");

        /// <summary>
        ///
        /// </summary>
        public static PricingOverrideUtcDay Sunday { get; } = new("sunday");

        /// <summary>
        ///
        /// </summary>
        public static PricingOverrideUtcDay Thursday { get; } = new("thursday");

        /// <summary>
        ///
        /// </summary>
        public static PricingOverrideUtcDay Tuesday { get; } = new("tuesday");

        /// <summary>
        ///
        /// </summary>
        public static PricingOverrideUtcDay Wednesday { get; } = new("wednesday");
        /// <summary>
        ///
        /// </summary>
        public static PricingOverrideUtcDay FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "friday" => Friday,
                "monday" => Monday,
                "saturday" => Saturday,
                "sunday" => Sunday,
                "thursday" => Thursday,
                "tuesday" => Tuesday,
                "wednesday" => Wednesday,
                _ => new PricingOverrideUtcDay(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "friday" => true,
            "monday" => true,
            "saturday" => true,
            "sunday" => true,
            "thursday" => true,
            "tuesday" => true,
            "wednesday" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(PricingOverrideUtcDay other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PricingOverrideUtcDay other && Equals(other);
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
        public static bool operator ==(PricingOverrideUtcDay left, PricingOverrideUtcDay right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PricingOverrideUtcDay left, PricingOverrideUtcDay right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingOverrideUtcDayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingOverrideUtcDay value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingOverrideUtcDay? ToEnum(string value)
        {
            return PricingOverrideUtcDay.FromValue(value);
        }
    }
}