
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TextExtendedConfigVariant2Verbosity : global::System.IEquatable<TextExtendedConfigVariant2Verbosity>
    {
        /// <summary>
        ///
        /// </summary>
        public TextExtendedConfigVariant2Verbosity(string value)
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
        public static TextExtendedConfigVariant2Verbosity High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static TextExtendedConfigVariant2Verbosity Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static TextExtendedConfigVariant2Verbosity Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static TextExtendedConfigVariant2Verbosity Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static TextExtendedConfigVariant2Verbosity Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static TextExtendedConfigVariant2Verbosity FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "high" => High,
                "low" => Low,
                "max" => Max,
                "medium" => Medium,
                "xhigh" => Xhigh,
                _ => new TextExtendedConfigVariant2Verbosity(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "high" => true,
            "low" => true,
            "max" => true,
            "medium" => true,
            "xhigh" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(TextExtendedConfigVariant2Verbosity other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextExtendedConfigVariant2Verbosity other && Equals(other);
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
        public static bool operator ==(TextExtendedConfigVariant2Verbosity left, TextExtendedConfigVariant2Verbosity right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextExtendedConfigVariant2Verbosity left, TextExtendedConfigVariant2Verbosity right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextExtendedConfigVariant2VerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextExtendedConfigVariant2Verbosity value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextExtendedConfigVariant2Verbosity? ToEnum(string value)
        {
            return TextExtendedConfigVariant2Verbosity.FromValue(value);
        }
    }
}