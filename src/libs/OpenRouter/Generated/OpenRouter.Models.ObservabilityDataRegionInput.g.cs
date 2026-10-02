
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `eu` is accepted as an alias for `europe` and normalizes to `europe`.<br/>
    /// Example: global
    /// </summary>
    public readonly partial struct ObservabilityDataRegionInput : global::System.IEquatable<ObservabilityDataRegionInput>
    {
        /// <summary>
        ///
        /// </summary>
        public ObservabilityDataRegionInput(string value)
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
        public static ObservabilityDataRegionInput Eu { get; } = new("eu");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDataRegionInput Europe { get; } = new("europe");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDataRegionInput Global { get; } = new("global");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDataRegionInput Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDataRegionInput FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "eu" => Eu,
                "europe" => Europe,
                "global" => Global,
                "us" => Us,
                _ => new ObservabilityDataRegionInput(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "eu" => true,
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
        public bool Equals(ObservabilityDataRegionInput other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityDataRegionInput other && Equals(other);
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
        public static bool operator ==(ObservabilityDataRegionInput left, ObservabilityDataRegionInput right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ObservabilityDataRegionInput left, ObservabilityDataRegionInput right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDataRegionInputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDataRegionInput value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDataRegionInput? ToEnum(string value)
        {
            return ObservabilityDataRegionInput.FromValue(value);
        }
    }
}