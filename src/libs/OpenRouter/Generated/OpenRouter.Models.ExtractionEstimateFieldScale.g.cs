
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ExtractionEstimateFieldScale : global::System.IEquatable<ExtractionEstimateFieldScale>
    {
        /// <summary>
        ///
        /// </summary>
        public ExtractionEstimateFieldScale(string value)
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
        public static ExtractionEstimateFieldScale Linear { get; } = new("linear");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionEstimateFieldScale Log { get; } = new("log");
        /// <summary>
        ///
        /// </summary>
        public static ExtractionEstimateFieldScale FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "linear" => Linear,
                "log" => Log,
                _ => new ExtractionEstimateFieldScale(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "linear" => true,
            "log" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ExtractionEstimateFieldScale other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtractionEstimateFieldScale other && Equals(other);
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
        public static bool operator ==(ExtractionEstimateFieldScale left, ExtractionEstimateFieldScale right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ExtractionEstimateFieldScale left, ExtractionEstimateFieldScale right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionEstimateFieldScaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionEstimateFieldScale value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionEstimateFieldScale? ToEnum(string value)
        {
            return ExtractionEstimateFieldScale.FromValue(value);
        }
    }
}