
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `popular` ranks apps by total token volume inside the date window. `trending` ranks apps by absolute excess token growth: window volume minus the average volume of the three equal-length periods immediately preceding the window. Apps with no excess growth are omitted from `trending` results.<br/>
    /// Default Value: popular<br/>
    /// Example: popular
    /// </summary>
    public readonly partial struct GetAppRankingsSort : global::System.IEquatable<GetAppRankingsSort>
    {
        /// <summary>
        ///
        /// </summary>
        public GetAppRankingsSort(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// window volume minus the average volume of the three equal-length periods immediately preceding the window. Apps with no excess growth are omitted from `trending` results.
        /// </summary>
        public static GetAppRankingsSort Popular { get; } = new("popular");

        /// <summary>
        /// window volume minus the average volume of the three equal-length periods immediately preceding the window. Apps with no excess growth are omitted from `trending` results.
        /// </summary>
        public static GetAppRankingsSort Trending { get; } = new("trending");
        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSort FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "popular" => Popular,
                "trending" => Trending,
                _ => new GetAppRankingsSort(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "popular" => true,
            "trending" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetAppRankingsSort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetAppRankingsSort other && Equals(other);
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
        public static bool operator ==(GetAppRankingsSort left, GetAppRankingsSort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetAppRankingsSort left, GetAppRankingsSort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAppRankingsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAppRankingsSort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAppRankingsSort? ToEnum(string value)
        {
            return GetAppRankingsSort.FromValue(value);
        }
    }
}