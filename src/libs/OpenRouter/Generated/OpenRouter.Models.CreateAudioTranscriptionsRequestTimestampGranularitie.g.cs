
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateAudioTranscriptionsRequestTimestampGranularitie : global::System.IEquatable<CreateAudioTranscriptionsRequestTimestampGranularitie>
    {
        /// <summary>
        ///
        /// </summary>
        public CreateAudioTranscriptionsRequestTimestampGranularitie(string value)
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
        public static CreateAudioTranscriptionsRequestTimestampGranularitie Segment { get; } = new("segment");

        /// <summary>
        ///
        /// </summary>
        public static CreateAudioTranscriptionsRequestTimestampGranularitie Word { get; } = new("word");
        /// <summary>
        ///
        /// </summary>
        public static CreateAudioTranscriptionsRequestTimestampGranularitie FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "segment" => Segment,
                "word" => Word,
                _ => new CreateAudioTranscriptionsRequestTimestampGranularitie(value),
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
        public bool Equals(CreateAudioTranscriptionsRequestTimestampGranularitie other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAudioTranscriptionsRequestTimestampGranularitie other && Equals(other);
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
        public static bool operator ==(CreateAudioTranscriptionsRequestTimestampGranularitie left, CreateAudioTranscriptionsRequestTimestampGranularitie right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateAudioTranscriptionsRequestTimestampGranularitie left, CreateAudioTranscriptionsRequestTimestampGranularitie right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAudioTranscriptionsRequestTimestampGranularitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioTranscriptionsRequestTimestampGranularitie value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioTranscriptionsRequestTimestampGranularitie? ToEnum(string value)
        {
            return CreateAudioTranscriptionsRequestTimestampGranularitie.FromValue(value);
        }
    }
}