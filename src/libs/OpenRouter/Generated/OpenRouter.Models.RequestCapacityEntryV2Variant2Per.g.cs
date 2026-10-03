
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RequestCapacityEntryV2Variant2Per : global::System.IEquatable<RequestCapacityEntryV2Variant2Per>
    {
        /// <summary>
        ///
        /// </summary>
        public RequestCapacityEntryV2Variant2Per(string value)
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
        public static RequestCapacityEntryV2Variant2Per Day { get; } = new("day");

        /// <summary>
        ///
        /// </summary>
        public static RequestCapacityEntryV2Variant2Per Hour { get; } = new("hour");

        /// <summary>
        ///
        /// </summary>
        public static RequestCapacityEntryV2Variant2Per Minute { get; } = new("minute");
        /// <summary>
        ///
        /// </summary>
        public static RequestCapacityEntryV2Variant2Per FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "day" => Day,
                "hour" => Hour,
                "minute" => Minute,
                _ => new RequestCapacityEntryV2Variant2Per(value),
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
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(RequestCapacityEntryV2Variant2Per other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestCapacityEntryV2Variant2Per other && Equals(other);
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
        public static bool operator ==(RequestCapacityEntryV2Variant2Per left, RequestCapacityEntryV2Variant2Per right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RequestCapacityEntryV2Variant2Per left, RequestCapacityEntryV2Variant2Per right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestCapacityEntryV2Variant2PerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestCapacityEntryV2Variant2Per value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestCapacityEntryV2Variant2Per? ToEnum(string value)
        {
            return RequestCapacityEntryV2Variant2Per.FromValue(value);
        }
    }
}