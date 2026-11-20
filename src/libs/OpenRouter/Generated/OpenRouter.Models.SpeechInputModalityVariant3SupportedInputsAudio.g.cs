
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `required`: an image reference is accepted only together with an audio reference. `excluded`: only without one. Absent: either.
    /// </summary>
    public readonly partial struct SpeechInputModalityVariant3SupportedInputsAudio : global::System.IEquatable<SpeechInputModalityVariant3SupportedInputsAudio>
    {
        /// <summary>
        ///
        /// </summary>
        public SpeechInputModalityVariant3SupportedInputsAudio(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// an image reference is accepted only together with an audio reference. `excluded`: only without one. Absent: either.
        /// </summary>
        public static SpeechInputModalityVariant3SupportedInputsAudio Excluded { get; } = new("excluded");

        /// <summary>
        /// an image reference is accepted only together with an audio reference. `excluded`: only without one. Absent: either.
        /// </summary>
        public static SpeechInputModalityVariant3SupportedInputsAudio Required { get; } = new("required");
        /// <summary>
        ///
        /// </summary>
        public static SpeechInputModalityVariant3SupportedInputsAudio FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "excluded" => Excluded,
                "required" => Required,
                _ => new SpeechInputModalityVariant3SupportedInputsAudio(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "excluded" => true,
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
        public bool Equals(SpeechInputModalityVariant3SupportedInputsAudio other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechInputModalityVariant3SupportedInputsAudio other && Equals(other);
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
        public static bool operator ==(SpeechInputModalityVariant3SupportedInputsAudio left, SpeechInputModalityVariant3SupportedInputsAudio right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpeechInputModalityVariant3SupportedInputsAudio left, SpeechInputModalityVariant3SupportedInputsAudio right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechInputModalityVariant3SupportedInputsAudioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechInputModalityVariant3SupportedInputsAudio value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechInputModalityVariant3SupportedInputsAudio? ToEnum(string value)
        {
            return SpeechInputModalityVariant3SupportedInputsAudio.FromValue(value);
        }
    }
}