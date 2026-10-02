
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Default Value: us
    /// </summary>
    public readonly partial struct ObservabilityNewrelicDestinationConfigRegion : global::System.IEquatable<ObservabilityNewrelicDestinationConfigRegion>
    {
        /// <summary>
        ///
        /// </summary>
        public ObservabilityNewrelicDestinationConfigRegion(string value)
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
        public static ObservabilityNewrelicDestinationConfigRegion Eu { get; } = new("eu");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityNewrelicDestinationConfigRegion Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static ObservabilityNewrelicDestinationConfigRegion FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "eu" => Eu,
                "us" => Us,
                _ => new ObservabilityNewrelicDestinationConfigRegion(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "eu" => true,
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
        public bool Equals(ObservabilityNewrelicDestinationConfigRegion other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityNewrelicDestinationConfigRegion other && Equals(other);
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
        public static bool operator ==(ObservabilityNewrelicDestinationConfigRegion left, ObservabilityNewrelicDestinationConfigRegion right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ObservabilityNewrelicDestinationConfigRegion left, ObservabilityNewrelicDestinationConfigRegion right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityNewrelicDestinationConfigRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityNewrelicDestinationConfigRegion value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityNewrelicDestinationConfigRegion? ToEnum(string value)
        {
            return ObservabilityNewrelicDestinationConfigRegion.FromValue(value);
        }
    }
}