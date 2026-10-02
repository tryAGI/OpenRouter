
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Restrict to requests whose context length falls in this bucket (`1K`, `10K`, `100K`, `1M`, or `10M`). Exact dataset — cannot be combined with `category` or `language_type`.<br/>
    /// Example: 100K
    /// </summary>
    public readonly partial struct GetRankingsDailyContextBucket : global::System.IEquatable<GetRankingsDailyContextBucket>
    {
        /// <summary>
        ///
        /// </summary>
        public GetRankingsDailyContextBucket(string value)
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
        public static GetRankingsDailyContextBucket x100k { get; } = new("100K");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyContextBucket x10k { get; } = new("10K");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyContextBucket x10m { get; } = new("10M");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyContextBucket x1k { get; } = new("1K");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyContextBucket x1m { get; } = new("1M");
        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyContextBucket FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "100K" => x100k,
                "10K" => x10k,
                "10M" => x10m,
                "1K" => x1k,
                "1M" => x1m,
                _ => new GetRankingsDailyContextBucket(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "100K" => true,
            "10K" => true,
            "10M" => true,
            "1K" => true,
            "1M" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetRankingsDailyContextBucket other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetRankingsDailyContextBucket other && Equals(other);
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
        public static bool operator ==(GetRankingsDailyContextBucket left, GetRankingsDailyContextBucket right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetRankingsDailyContextBucket left, GetRankingsDailyContextBucket right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRankingsDailyContextBucketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRankingsDailyContextBucket value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRankingsDailyContextBucket? ToEnum(string value)
        {
            return GetRankingsDailyContextBucket.FromValue(value);
        }
    }
}