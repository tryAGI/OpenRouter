
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Return results for one exact OpenRouter benchmark. A `search_*` value narrows the response to search results only; a classic value narrows the OpenRouter items and leaves other sources' items as they are.<br/>
    /// Example: search_widesearch
    /// </summary>
    public readonly partial struct GetBenchmarksBenchmarkType : global::System.IEquatable<GetBenchmarksBenchmarkType>
    {
        /// <summary>
        ///
        /// </summary>
        public GetBenchmarksBenchmarkType(string value)
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
        public static GetBenchmarksBenchmarkType GpqaDiamond { get; } = new("gpqa_diamond");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksBenchmarkType SearchBrowsecomp { get; } = new("search_browsecomp");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksBenchmarkType SearchDsqa { get; } = new("search_dsqa");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksBenchmarkType SearchHle { get; } = new("search_hle");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksBenchmarkType SearchWidesearch { get; } = new("search_widesearch");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksBenchmarkType TauBenchVerifiedAirline { get; } = new("tau_bench_verified_airline");
        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksBenchmarkType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "gpqa_diamond" => GpqaDiamond,
                "search_browsecomp" => SearchBrowsecomp,
                "search_dsqa" => SearchDsqa,
                "search_hle" => SearchHle,
                "search_widesearch" => SearchWidesearch,
                "tau_bench_verified_airline" => TauBenchVerifiedAirline,
                _ => new GetBenchmarksBenchmarkType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "gpqa_diamond" => true,
            "search_browsecomp" => true,
            "search_dsqa" => true,
            "search_hle" => true,
            "search_widesearch" => true,
            "tau_bench_verified_airline" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetBenchmarksBenchmarkType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetBenchmarksBenchmarkType other && Equals(other);
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
        public static bool operator ==(GetBenchmarksBenchmarkType left, GetBenchmarksBenchmarkType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetBenchmarksBenchmarkType left, GetBenchmarksBenchmarkType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBenchmarksBenchmarkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBenchmarksBenchmarkType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBenchmarksBenchmarkType? ToEnum(string value)
        {
            return GetBenchmarksBenchmarkType.FromValue(value);
        }
    }
}