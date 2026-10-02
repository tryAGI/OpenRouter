
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// How this metric value should be formatted for display (e.g. percent → multiply by 100 and append %, currency → prefix with $)<br/>
    /// Example: number
    /// </summary>
    public readonly partial struct GetAnalyticsMetaResponseDataMetricDisplayFormat : global::System.IEquatable<GetAnalyticsMetaResponseDataMetricDisplayFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public GetAnalyticsMetaResponseDataMetricDisplayFormat(string value)
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
        public static GetAnalyticsMetaResponseDataMetricDisplayFormat Currency { get; } = new("currency");

        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataMetricDisplayFormat Latency { get; } = new("latency");

        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataMetricDisplayFormat Number { get; } = new("number");

        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataMetricDisplayFormat Percent { get; } = new("percent");

        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataMetricDisplayFormat Throughput { get; } = new("throughput");
        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataMetricDisplayFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "currency" => Currency,
                "latency" => Latency,
                "number" => Number,
                "percent" => Percent,
                "throughput" => Throughput,
                _ => new GetAnalyticsMetaResponseDataMetricDisplayFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "currency" => true,
            "latency" => true,
            "number" => true,
            "percent" => true,
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
        public bool Equals(GetAnalyticsMetaResponseDataMetricDisplayFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetAnalyticsMetaResponseDataMetricDisplayFormat other && Equals(other);
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
        public static bool operator ==(GetAnalyticsMetaResponseDataMetricDisplayFormat left, GetAnalyticsMetaResponseDataMetricDisplayFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetAnalyticsMetaResponseDataMetricDisplayFormat left, GetAnalyticsMetaResponseDataMetricDisplayFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsMetaResponseDataMetricDisplayFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsMetaResponseDataMetricDisplayFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsMetaResponseDataMetricDisplayFormat? ToEnum(string value)
        {
            return GetAnalyticsMetaResponseDataMetricDisplayFormat.FromValue(value);
        }
    }
}