
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Time grain of each row. `day` (default) returns the per-UTC-day series; `week` buckets by ISO week start; `month` buckets by month start. With `category` or `language_type` only `week` (default) and `month` are available — `day` is rejected with a 400 because those datasets are aggregated weekly. For those sampled datasets `period=month` buckets each week by its week-start month, so totals are approximate at month boundaries.<br/>
    /// Example: day
    /// </summary>
    public readonly partial struct GetRankingsDailyPeriod : global::System.IEquatable<GetRankingsDailyPeriod>
    {
        /// <summary>
        ///
        /// </summary>
        public GetRankingsDailyPeriod(string value)
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
        public static GetRankingsDailyPeriod Day { get; } = new("day");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyPeriod Month { get; } = new("month");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyPeriod Week { get; } = new("week");
        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyPeriod FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "day" => Day,
                "month" => Month,
                "week" => Week,
                _ => new GetRankingsDailyPeriod(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "day" => true,
            "month" => true,
            "week" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetRankingsDailyPeriod other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetRankingsDailyPeriod other && Equals(other);
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
        public static bool operator ==(GetRankingsDailyPeriod left, GetRankingsDailyPeriod right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetRankingsDailyPeriod left, GetRankingsDailyPeriod right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRankingsDailyPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRankingsDailyPeriod value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRankingsDailyPeriod? ToEnum(string value)
        {
            return GetRankingsDailyPeriod.FromValue(value);
        }
    }
}