
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The source filter applied, or null when all sources are returned.<br/>
    /// Example: artificial-analysis
    /// </summary>
    public readonly partial struct UnifiedBenchmarksMetaSource : global::System.IEquatable<UnifiedBenchmarksMetaSource>
    {
        /// <summary>
        ///
        /// </summary>
        public UnifiedBenchmarksMetaSource(string value)
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
        public static UnifiedBenchmarksMetaSource ArtificialAnalysis { get; } = new("artificial-analysis");

        /// <summary>
        ///
        /// </summary>
        public static UnifiedBenchmarksMetaSource DesignArena { get; } = new("design-arena");

        /// <summary>
        ///
        /// </summary>
        public static UnifiedBenchmarksMetaSource Openrouter { get; } = new("openrouter");
        /// <summary>
        ///
        /// </summary>
        public static UnifiedBenchmarksMetaSource FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "artificial-analysis" => ArtificialAnalysis,
                "design-arena" => DesignArena,
                "openrouter" => Openrouter,
                _ => new UnifiedBenchmarksMetaSource(value),
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
        public bool Equals(UnifiedBenchmarksMetaSource other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnifiedBenchmarksMetaSource other && Equals(other);
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
        public static bool operator ==(UnifiedBenchmarksMetaSource left, UnifiedBenchmarksMetaSource right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnifiedBenchmarksMetaSource left, UnifiedBenchmarksMetaSource right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedBenchmarksMetaSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksMetaSource value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksMetaSource? ToEnum(string value)
        {
            return UnifiedBenchmarksMetaSource.FromValue(value);
        }
    }
}