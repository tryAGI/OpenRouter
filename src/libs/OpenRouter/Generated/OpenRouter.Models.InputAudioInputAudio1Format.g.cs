
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InputAudioInputAudio1Format : global::System.IEquatable<InputAudioInputAudio1Format>
    {
        /// <summary>
        ///
        /// </summary>
        public InputAudioInputAudio1Format(string value)
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
        public static InputAudioInputAudio1Format Mp3 { get; } = new("mp3");

        /// <summary>
        ///
        /// </summary>
        public static InputAudioInputAudio1Format Wav { get; } = new("wav");
        /// <summary>
        ///
        /// </summary>
        public static InputAudioInputAudio1Format FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "mp3" => Mp3,
                "wav" => Wav,
                _ => new InputAudioInputAudio1Format(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "mp3" => true,
            "wav" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InputAudioInputAudio1Format other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputAudioInputAudio1Format other && Equals(other);
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
        public static bool operator ==(InputAudioInputAudio1Format left, InputAudioInputAudio1Format right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputAudioInputAudio1Format left, InputAudioInputAudio1Format right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioInputAudio1FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioInputAudio1Format value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioInputAudio1Format? ToEnum(string value)
        {
            return InputAudioInputAudio1Format.FromValue(value);
        }
    }
}