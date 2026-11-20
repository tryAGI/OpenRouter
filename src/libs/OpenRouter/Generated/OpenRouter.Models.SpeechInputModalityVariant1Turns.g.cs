
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `optional`: `input` may also be a multi-speaker turn array, which cannot be combined with `input_references`. `required`: `input` must be a turn array with at least two distinct voices. Absent: `input` is a string.
    /// </summary>
    public readonly partial struct SpeechInputModalityVariant1Turns : global::System.IEquatable<SpeechInputModalityVariant1Turns>
    {
        /// <summary>
        ///
        /// </summary>
        public SpeechInputModalityVariant1Turns(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `input` may also be a multi-speaker turn array, which cannot be combined with `input_references`. `required`: `input` must be a turn array with at least two distinct voices. Absent: `input` is a string.
        /// </summary>
        public static SpeechInputModalityVariant1Turns Optional { get; } = new("optional");

        /// <summary>
        /// `input` may also be a multi-speaker turn array, which cannot be combined with `input_references`. `required`: `input` must be a turn array with at least two distinct voices. Absent: `input` is a string.
        /// </summary>
        public static SpeechInputModalityVariant1Turns Required { get; } = new("required");
        /// <summary>
        ///
        /// </summary>
        public static SpeechInputModalityVariant1Turns FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "optional" => Optional,
                "required" => Required,
                _ => new SpeechInputModalityVariant1Turns(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "optional" => true,
            "required" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(SpeechInputModalityVariant1Turns other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechInputModalityVariant1Turns other && Equals(other);
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
        public static bool operator ==(SpeechInputModalityVariant1Turns left, SpeechInputModalityVariant1Turns right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpeechInputModalityVariant1Turns left, SpeechInputModalityVariant1Turns right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechInputModalityVariant1TurnsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechInputModalityVariant1Turns value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechInputModalityVariant1Turns? ToEnum(string value)
        {
            return SpeechInputModalityVariant1Turns.FromValue(value);
        }
    }
}