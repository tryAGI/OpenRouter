
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The provider sorting strategy (price, throughput, latency)<br/>
    /// Example: price
    /// </summary>
    public readonly partial struct ProviderSortConfigBy : global::System.IEquatable<ProviderSortConfigBy>
    {
        /// <summary>
        ///
        /// </summary>
        public ProviderSortConfigBy(string value)
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
        public static ProviderSortConfigBy Exacto { get; } = new("exacto");

        /// <summary>
        ///
        /// </summary>
        public static ProviderSortConfigBy Latency { get; } = new("latency");

        /// <summary>
        ///
        /// </summary>
        public static ProviderSortConfigBy Price { get; } = new("price");

        /// <summary>
        ///
        /// </summary>
        public static ProviderSortConfigBy Throughput { get; } = new("throughput");
        /// <summary>
        ///
        /// </summary>
        public static ProviderSortConfigBy FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "exacto" => Exacto,
                "latency" => Latency,
                "price" => Price,
                "throughput" => Throughput,
                _ => new ProviderSortConfigBy(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "exacto" => true,
            "latency" => true,
            "price" => true,
            "throughput" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ProviderSortConfigBy other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderSortConfigBy other && Equals(other);
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
        public static bool operator ==(ProviderSortConfigBy left, ProviderSortConfigBy right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderSortConfigBy left, ProviderSortConfigBy right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderSortConfigByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderSortConfigBy value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderSortConfigBy? ToEnum(string value)
        {
            return ProviderSortConfigBy.FromValue(value);
        }
    }
}