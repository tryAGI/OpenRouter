
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputCapacityEntryV2Variant1Per : global::System.IEquatable<OutputCapacityEntryV2Variant1Per>
    {
        /// <summary>
        ///
        /// </summary>
        public OutputCapacityEntryV2Variant1Per(string value)
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
        public static OutputCapacityEntryV2Variant1Per Day { get; } = new("day");

        /// <summary>
        ///
        /// </summary>
        public static OutputCapacityEntryV2Variant1Per Hour { get; } = new("hour");

        /// <summary>
        ///
        /// </summary>
        public static OutputCapacityEntryV2Variant1Per Minute { get; } = new("minute");
        /// <summary>
        ///
        /// </summary>
        public static OutputCapacityEntryV2Variant1Per FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "day" => Day,
                "hour" => Hour,
                "minute" => Minute,
                _ => new OutputCapacityEntryV2Variant1Per(value),
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
        public bool Equals(OutputCapacityEntryV2Variant1Per other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputCapacityEntryV2Variant1Per other && Equals(other);
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
        public static bool operator ==(OutputCapacityEntryV2Variant1Per left, OutputCapacityEntryV2Variant1Per right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputCapacityEntryV2Variant1Per left, OutputCapacityEntryV2Variant1Per right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputCapacityEntryV2Variant1PerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputCapacityEntryV2Variant1Per value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputCapacityEntryV2Variant1Per? ToEnum(string value)
        {
            return OutputCapacityEntryV2Variant1Per.FromValue(value);
        }
    }
}