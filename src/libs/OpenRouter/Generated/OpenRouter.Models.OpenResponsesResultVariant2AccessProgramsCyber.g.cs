
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OpenResponsesResultVariant2AccessProgramsCyber : global::System.IEquatable<OpenResponsesResultVariant2AccessProgramsCyber>
    {
        /// <summary>
        ///
        /// </summary>
        public OpenResponsesResultVariant2AccessProgramsCyber(string value)
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
        public static OpenResponsesResultVariant2AccessProgramsCyber DaybreakBlue { get; } = new("daybreak_blue");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesResultVariant2AccessProgramsCyber DaybreakRed { get; } = new("daybreak_red");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesResultVariant2AccessProgramsCyber Standard { get; } = new("standard");
        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesResultVariant2AccessProgramsCyber FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "daybreak_blue" => DaybreakBlue,
                "daybreak_red" => DaybreakRed,
                "standard" => Standard,
                _ => new OpenResponsesResultVariant2AccessProgramsCyber(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "daybreak_blue" => true,
            "daybreak_red" => true,
            "standard" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OpenResponsesResultVariant2AccessProgramsCyber other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenResponsesResultVariant2AccessProgramsCyber other && Equals(other);
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
        public static bool operator ==(OpenResponsesResultVariant2AccessProgramsCyber left, OpenResponsesResultVariant2AccessProgramsCyber right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OpenResponsesResultVariant2AccessProgramsCyber left, OpenResponsesResultVariant2AccessProgramsCyber right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenResponsesResultVariant2AccessProgramsCyberExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenResponsesResultVariant2AccessProgramsCyber value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenResponsesResultVariant2AccessProgramsCyber? ToEnum(string value)
        {
            return OpenResponsesResultVariant2AccessProgramsCyber.FromValue(value);
        }
    }
}