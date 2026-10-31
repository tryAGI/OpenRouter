
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Set to `image` or `document` when the answer was read from an image or a PDF rather than the state text.
    /// </summary>
    public readonly partial struct ExtractionForecastAnswerSource : global::System.IEquatable<ExtractionForecastAnswerSource>
    {
        /// <summary>
        ///
        /// </summary>
        public ExtractionForecastAnswerSource(string value)
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
        public static ExtractionForecastAnswerSource Document { get; } = new("document");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastAnswerSource Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastAnswerSource State { get; } = new("state");
        /// <summary>
        ///
        /// </summary>
        public static ExtractionForecastAnswerSource FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "document" => Document,
                "image" => Image,
                "state" => State,
                _ => new ExtractionForecastAnswerSource(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "document" => true,
            "image" => true,
            "state" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ExtractionForecastAnswerSource other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtractionForecastAnswerSource other && Equals(other);
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
        public static bool operator ==(ExtractionForecastAnswerSource left, ExtractionForecastAnswerSource right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ExtractionForecastAnswerSource left, ExtractionForecastAnswerSource right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionForecastAnswerSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionForecastAnswerSource value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionForecastAnswerSource? ToEnum(string value)
        {
            return ExtractionForecastAnswerSource.FromValue(value);
        }
    }
}