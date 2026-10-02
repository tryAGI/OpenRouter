
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Benchmark source to query. Determines the shape of the returned items. When omitted, returns results from all sources.<br/>
    /// Example: artificial-analysis
    /// </summary>
    public readonly partial struct GetBenchmarksSource : global::System.IEquatable<GetBenchmarksSource>
    {
        /// <summary>
        ///
        /// </summary>
        public GetBenchmarksSource(string value)
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
        public static GetBenchmarksSource ArtificialAnalysis { get; } = new("artificial-analysis");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksSource DesignArena { get; } = new("design-arena");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksSource Openrouter { get; } = new("openrouter");
        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksSource FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "artificial-analysis" => ArtificialAnalysis,
                "design-arena" => DesignArena,
                "openrouter" => Openrouter,
                _ => new GetBenchmarksSource(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "artificial-analysis" => true,
            "design-arena" => true,
            "openrouter" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetBenchmarksSource other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetBenchmarksSource other && Equals(other);
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
        public static bool operator ==(GetBenchmarksSource left, GetBenchmarksSource right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetBenchmarksSource left, GetBenchmarksSource right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBenchmarksSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBenchmarksSource value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBenchmarksSource? ToEnum(string value)
        {
            return GetBenchmarksSource.FromValue(value);
        }
    }
}