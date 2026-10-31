
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ExtractionListFieldItems : global::System.IEquatable<ExtractionListFieldItems>
    {
        /// <summary>
        ///
        /// </summary>
        public ExtractionListFieldItems(string value)
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
        public static ExtractionListFieldItems Date { get; } = new("date");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionListFieldItems Number { get; } = new("number");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionListFieldItems Text { get; } = new("text");
        /// <summary>
        ///
        /// </summary>
        public static ExtractionListFieldItems FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "date" => Date,
                "number" => Number,
                "text" => Text,
                _ => new ExtractionListFieldItems(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "date" => true,
            "number" => true,
            "text" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ExtractionListFieldItems other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtractionListFieldItems other && Equals(other);
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
        public static bool operator ==(ExtractionListFieldItems left, ExtractionListFieldItems right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ExtractionListFieldItems left, ExtractionListFieldItems right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionListFieldItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionListFieldItems value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionListFieldItems? ToEnum(string value)
        {
            return ExtractionListFieldItems.FromValue(value);
        }
    }
}