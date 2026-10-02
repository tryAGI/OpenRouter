
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// A timestamp detail level for verbose_json transcription responses.<br/>
    /// Example: word
    /// </summary>
    public readonly partial struct STTTimestampGranularity : global::System.IEquatable<STTTimestampGranularity>
    {
        /// <summary>
        ///
        /// </summary>
        public STTTimestampGranularity(string value)
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
        public static STTTimestampGranularity Segment { get; } = new("segment");

        /// <summary>
        ///
        /// </summary>
        public static STTTimestampGranularity Word { get; } = new("word");
        /// <summary>
        ///
        /// </summary>
        public static STTTimestampGranularity FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "segment" => Segment,
                "word" => Word,
                _ => new STTTimestampGranularity(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "segment" => true,
            "word" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(STTTimestampGranularity other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is STTTimestampGranularity other && Equals(other);
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
        public static bool operator ==(STTTimestampGranularity left, STTTimestampGranularity right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(STTTimestampGranularity left, STTTimestampGranularity right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTimestampGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTimestampGranularity value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTimestampGranularity? ToEnum(string value)
        {
            return STTTimestampGranularity.FromValue(value);
        }
    }
}