
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ExtractionForecastFieldInterval : global::System.IEquatable<ExtractionForecastFieldInterval>
    {
        /// <summary>
        ///
        /// </summary>
        public ExtractionForecastFieldInterval(string value)
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
        public static ExtractionForecastFieldInterval Day { get; } = new("day");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastFieldInterval Hour { get; } = new("hour");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastFieldInterval Minute { get; } = new("minute");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastFieldInterval Month { get; } = new("month");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastFieldInterval Quarter { get; } = new("quarter");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastFieldInterval Step { get; } = new("step");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastFieldInterval Week { get; } = new("week");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastFieldInterval Year { get; } = new("year");
        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastFieldInterval FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "day" => Day,
                "hour" => Hour,
                "minute" => Minute,
                "month" => Month,
                "quarter" => Quarter,
                "step" => Step,
                "week" => Week,
                "year" => Year,
                _ => new ExtractionForecastFieldInterval(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "day" => true,
            "hour" => true,
            "minute" => true,
            "month" => true,
            "quarter" => true,
            "step" => true,
            "week" => true,
            "year" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ExtractionForecastFieldInterval other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtractionForecastFieldInterval other && Equals(other);
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
        public static bool operator ==(ExtractionForecastFieldInterval left, ExtractionForecastFieldInterval right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ExtractionForecastFieldInterval left, ExtractionForecastFieldInterval right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionForecastFieldIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionForecastFieldInterval value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionForecastFieldInterval? ToEnum(string value)
        {
            return ExtractionForecastFieldInterval.FromValue(value);
        }
    }
}