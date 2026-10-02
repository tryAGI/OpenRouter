
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// OpenRouter benchmark evaluation type.<br/>
    /// Example: gpqa_diamond
    /// </summary>
    public readonly partial struct UnifiedBenchmarksORItemBenchmarkType : global::System.IEquatable<UnifiedBenchmarksORItemBenchmarkType>
    {
        /// <summary>
        ///
        /// </summary>
        public UnifiedBenchmarksORItemBenchmarkType(string value)
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
        public static UnifiedBenchmarksORItemBenchmarkType GpqaDiamond { get; } = new("gpqa_diamond");

        /// <summary>
        ///
        /// </summary>
        public static UnifiedBenchmarksORItemBenchmarkType TauBenchVerifiedAirline { get; } = new("tau_bench_verified_airline");
        /// <summary>
        ///
        /// </summary>
        public static UnifiedBenchmarksORItemBenchmarkType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "gpqa_diamond" => GpqaDiamond,
                "tau_bench_verified_airline" => TauBenchVerifiedAirline,
                _ => new UnifiedBenchmarksORItemBenchmarkType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "gpqa_diamond" => true,
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
        public bool Equals(UnifiedBenchmarksORItemBenchmarkType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnifiedBenchmarksORItemBenchmarkType other && Equals(other);
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
        public static bool operator ==(UnifiedBenchmarksORItemBenchmarkType left, UnifiedBenchmarksORItemBenchmarkType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnifiedBenchmarksORItemBenchmarkType left, UnifiedBenchmarksORItemBenchmarkType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedBenchmarksORItemBenchmarkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksORItemBenchmarkType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksORItemBenchmarkType? ToEnum(string value)
        {
            return UnifiedBenchmarksORItemBenchmarkType.FromValue(value);
        }
    }
}