
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Kind of entry; omitted or "word" for spoken words, "audio_event" for non-speech sounds the provider tags with timestamps<br/>
    /// Example: word
    /// </summary>
    public readonly partial struct STTWordType : global::System.IEquatable<STTWordType>
    {
        /// <summary>
        ///
        /// </summary>
        public STTWordType(string value)
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
        public static STTWordType AudioEvent { get; } = new("audio_event");

        /// <summary>
        ///
        /// </summary>
        public static STTWordType Word { get; } = new("word");
        /// <summary>
        ///
        /// </summary>
        public static STTWordType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audio_event" => AudioEvent,
                "word" => Word,
                _ => new STTWordType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audio_event" => true,
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
        public bool Equals(STTWordType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is STTWordType other && Equals(other);
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
        public static bool operator ==(STTWordType left, STTWordType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(STTWordType left, STTWordType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTWordTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTWordType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTWordType? ToEnum(string value)
        {
            return STTWordType.FromValue(value);
        }
    }
}