
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Audio output format<br/>
    /// Default Value: pcm<br/>
    /// Example: pcm
    /// </summary>
    public readonly partial struct SpeechRequestResponseFormat : global::System.IEquatable<SpeechRequestResponseFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public SpeechRequestResponseFormat(string value)
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
        public static SpeechRequestResponseFormat Mp3 { get; } = new("mp3");

        /// <summary>
        ///
        /// </summary>
        public static SpeechRequestResponseFormat Pcm { get; } = new("pcm");
        /// <summary>
        ///
        /// </summary>
        public static SpeechRequestResponseFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "mp3" => Mp3,
                "pcm" => Pcm,
                _ => new SpeechRequestResponseFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "mp3" => true,
            "pcm" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(SpeechRequestResponseFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechRequestResponseFormat other && Equals(other);
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
        public static bool operator ==(SpeechRequestResponseFormat left, SpeechRequestResponseFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpeechRequestResponseFormat left, SpeechRequestResponseFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestResponseFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestResponseFormat? ToEnum(string value)
        {
            return SpeechRequestResponseFormat.FromValue(value);
        }
    }
}