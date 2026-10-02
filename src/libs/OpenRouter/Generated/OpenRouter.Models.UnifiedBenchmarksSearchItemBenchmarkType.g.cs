
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// OpenRouter search benchmark.<br/>
    /// Example: search_browsecomp
    /// </summary>
    public readonly partial struct UnifiedBenchmarksSearchItemBenchmarkType : global::System.IEquatable<UnifiedBenchmarksSearchItemBenchmarkType>
    {
        /// <summary>
        ///
        /// </summary>
        public UnifiedBenchmarksSearchItemBenchmarkType(string value)
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
        public static UnifiedBenchmarksSearchItemBenchmarkType SearchBrowsecomp { get; } = new("search_browsecomp");

        /// <summary>
        ///
        /// </summary>
        public static UnifiedBenchmarksSearchItemBenchmarkType SearchDsqa { get; } = new("search_dsqa");

        /// <summary>
        ///
        /// </summary>
        public static UnifiedBenchmarksSearchItemBenchmarkType SearchHle { get; } = new("search_hle");

        /// <summary>
        ///
        /// </summary>
        public static UnifiedBenchmarksSearchItemBenchmarkType SearchWidesearch { get; } = new("search_widesearch");
        /// <summary>
        ///
        /// </summary>
        public static UnifiedBenchmarksSearchItemBenchmarkType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "search_browsecomp" => SearchBrowsecomp,
                "search_dsqa" => SearchDsqa,
                "search_hle" => SearchHle,
                "search_widesearch" => SearchWidesearch,
                _ => new UnifiedBenchmarksSearchItemBenchmarkType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "search_browsecomp" => true,
            "search_dsqa" => true,
            "search_hle" => true,
            "search_widesearch" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(UnifiedBenchmarksSearchItemBenchmarkType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnifiedBenchmarksSearchItemBenchmarkType other && Equals(other);
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
        public static bool operator ==(UnifiedBenchmarksSearchItemBenchmarkType left, UnifiedBenchmarksSearchItemBenchmarkType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnifiedBenchmarksSearchItemBenchmarkType left, UnifiedBenchmarksSearchItemBenchmarkType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedBenchmarksSearchItemBenchmarkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksSearchItemBenchmarkType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksSearchItemBenchmarkType? ToEnum(string value)
        {
            return UnifiedBenchmarksSearchItemBenchmarkType.FromValue(value);
        }
    }
}