
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: global
    /// </summary>
    public readonly partial struct ObservabilityDataRegion : global::System.IEquatable<ObservabilityDataRegion>
    {
        /// <summary>
        ///
        /// </summary>
        public ObservabilityDataRegion(string value)
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
        public static ObservabilityDataRegion Europe { get; } = new("europe");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDataRegion Global { get; } = new("global");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDataRegion Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDataRegion FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "europe" => Europe,
                "global" => Global,
                "us" => Us,
                _ => new ObservabilityDataRegion(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "europe" => true,
            "global" => true,
            "us" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ObservabilityDataRegion other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityDataRegion other && Equals(other);
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
        public static bool operator ==(ObservabilityDataRegion left, ObservabilityDataRegion right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ObservabilityDataRegion left, ObservabilityDataRegion right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDataRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDataRegion value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDataRegion? ToEnum(string value)
        {
            return ObservabilityDataRegion.FromValue(value);
        }
    }
}