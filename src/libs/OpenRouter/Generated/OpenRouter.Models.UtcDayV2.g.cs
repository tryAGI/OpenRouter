
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UtcDayV2 : global::System.IEquatable<UtcDayV2>
    {
        /// <summary>
        ///
        /// </summary>
        public UtcDayV2(string value)
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
        public static UtcDayV2 Friday { get; } = new("friday");

        /// <summary>
        ///
        /// </summary>
        public static UtcDayV2 Monday { get; } = new("monday");

        /// <summary>
        ///
        /// </summary>
        public static UtcDayV2 Saturday { get; } = new("saturday");

        /// <summary>
        ///
        /// </summary>
        public static UtcDayV2 Sunday { get; } = new("sunday");

        /// <summary>
        ///
        /// </summary>
        public static UtcDayV2 Thursday { get; } = new("thursday");

        /// <summary>
        ///
        /// </summary>
        public static UtcDayV2 Tuesday { get; } = new("tuesday");

        /// <summary>
        ///
        /// </summary>
        public static UtcDayV2 Wednesday { get; } = new("wednesday");
        /// <summary>
        ///
        /// </summary>
        public static UtcDayV2 FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "friday" => Friday,
                "monday" => Monday,
                "saturday" => Saturday,
                "sunday" => Sunday,
                "thursday" => Thursday,
                "tuesday" => Tuesday,
                "wednesday" => Wednesday,
                _ => new UtcDayV2(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "friday" => true,
            "monday" => true,
            "saturday" => true,
            "sunday" => true,
            "thursday" => true,
            "tuesday" => true,
            "wednesday" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(UtcDayV2 other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UtcDayV2 other && Equals(other);
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
        public static bool operator ==(UtcDayV2 left, UtcDayV2 right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UtcDayV2 left, UtcDayV2 right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UtcDayV2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UtcDayV2 value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UtcDayV2? ToEnum(string value)
        {
            return UtcDayV2.FromValue(value);
        }
    }
}