
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Identifies the meaning of `primary_score`: `f1_by_item` for WideSearch, `accuracy` for all other search benchmarks.<br/>
    /// Example: accuracy
    /// </summary>
    public readonly partial struct UnifiedBenchmarksSearchItemPrimaryMetric : global::System.IEquatable<UnifiedBenchmarksSearchItemPrimaryMetric>
    {
        /// <summary>
        ///
        /// </summary>
        public UnifiedBenchmarksSearchItemPrimaryMetric(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `f1_by_item` for WideSearch, `accuracy` for all other search benchmarks.
        /// </summary>
        public static UnifiedBenchmarksSearchItemPrimaryMetric Accuracy { get; } = new("accuracy");

        /// <summary>
        /// `f1_by_item` for WideSearch, `accuracy` for all other search benchmarks.
        /// </summary>
        public static UnifiedBenchmarksSearchItemPrimaryMetric F1ByItem { get; } = new("f1_by_item");
        /// <summary>
        ///
        /// </summary>
        public static UnifiedBenchmarksSearchItemPrimaryMetric FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "accuracy" => Accuracy,
                "f1_by_item" => F1ByItem,
                _ => new UnifiedBenchmarksSearchItemPrimaryMetric(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "accuracy" => true,
            "f1_by_item" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(UnifiedBenchmarksSearchItemPrimaryMetric other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnifiedBenchmarksSearchItemPrimaryMetric other && Equals(other);
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
        public static bool operator ==(UnifiedBenchmarksSearchItemPrimaryMetric left, UnifiedBenchmarksSearchItemPrimaryMetric right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnifiedBenchmarksSearchItemPrimaryMetric left, UnifiedBenchmarksSearchItemPrimaryMetric right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedBenchmarksSearchItemPrimaryMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksSearchItemPrimaryMetric value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksSearchItemPrimaryMetric? ToEnum(string value)
        {
            return UnifiedBenchmarksSearchItemPrimaryMetric.FromValue(value);
        }
    }
}