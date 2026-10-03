
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InputCapacityEntryV2Per : global::System.IEquatable<InputCapacityEntryV2Per>
    {
        /// <summary>
        ///
        /// </summary>
        public InputCapacityEntryV2Per(string value)
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
        public static InputCapacityEntryV2Per Day { get; } = new("day");

        /// <summary>
        ///
        /// </summary>
        public static InputCapacityEntryV2Per Hour { get; } = new("hour");

        /// <summary>
        ///
        /// </summary>
        public static InputCapacityEntryV2Per Minute { get; } = new("minute");
        /// <summary>
        ///
        /// </summary>
        public static InputCapacityEntryV2Per FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "day" => Day,
                "hour" => Hour,
                "minute" => Minute,
                _ => new InputCapacityEntryV2Per(value),
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
        public bool Equals(InputCapacityEntryV2Per other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputCapacityEntryV2Per other && Equals(other);
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
        public static bool operator ==(InputCapacityEntryV2Per left, InputCapacityEntryV2Per right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputCapacityEntryV2Per left, InputCapacityEntryV2Per right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputCapacityEntryV2PerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputCapacityEntryV2Per value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputCapacityEntryV2Per? ToEnum(string value)
        {
            return InputCapacityEntryV2Per.FromValue(value);
        }
    }
}