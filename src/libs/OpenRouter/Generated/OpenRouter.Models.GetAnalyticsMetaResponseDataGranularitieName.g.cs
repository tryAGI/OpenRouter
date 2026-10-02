
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Granularity identifier<br/>
    /// Example: day
    /// </summary>
    public readonly partial struct GetAnalyticsMetaResponseDataGranularitieName : global::System.IEquatable<GetAnalyticsMetaResponseDataGranularitieName>
    {
        /// <summary>
        ///
        /// </summary>
        public GetAnalyticsMetaResponseDataGranularitieName(string value)
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
        public static GetAnalyticsMetaResponseDataGranularitieName Day { get; } = new("day");

        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataGranularitieName Hour { get; } = new("hour");

        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataGranularitieName Minute { get; } = new("minute");

        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataGranularitieName Month { get; } = new("month");

        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataGranularitieName Week { get; } = new("week");
        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataGranularitieName FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "day" => Day,
                "hour" => Hour,
                "minute" => Minute,
                "month" => Month,
                "week" => Week,
                _ => new GetAnalyticsMetaResponseDataGranularitieName(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "day" => true,
            "hour" => true,
            "minute" => true,
            "month" => true,
            "week" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetAnalyticsMetaResponseDataGranularitieName other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetAnalyticsMetaResponseDataGranularitieName other && Equals(other);
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
        public static bool operator ==(GetAnalyticsMetaResponseDataGranularitieName left, GetAnalyticsMetaResponseDataGranularitieName right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetAnalyticsMetaResponseDataGranularitieName left, GetAnalyticsMetaResponseDataGranularitieName right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsMetaResponseDataGranularitieNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsMetaResponseDataGranularitieName value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsMetaResponseDataGranularitieName? ToEnum(string value)
        {
            return GetAnalyticsMetaResponseDataGranularitieName.FromValue(value);
        }
    }
}