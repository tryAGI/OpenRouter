
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The response format. "json" (default) returns { text, usage }; "verbose_json" additionally returns task, language, duration, and segment-level timestamps (OpenAI-compatible providers only).
    /// </summary>
    public readonly partial struct CreateAudioTranscriptionsRequestResponseFormat : global::System.IEquatable<CreateAudioTranscriptionsRequestResponseFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public CreateAudioTranscriptionsRequestResponseFormat(string value)
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
        public static CreateAudioTranscriptionsRequestResponseFormat Json { get; } = new("json");

        /// <summary>
        ///
        /// </summary>
        public static CreateAudioTranscriptionsRequestResponseFormat VerboseJson { get; } = new("verbose_json");
        /// <summary>
        ///
        /// </summary>
        public static CreateAudioTranscriptionsRequestResponseFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "json" => Json,
                "verbose_json" => VerboseJson,
                _ => new CreateAudioTranscriptionsRequestResponseFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "json" => true,
            "verbose_json" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CreateAudioTranscriptionsRequestResponseFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAudioTranscriptionsRequestResponseFormat other && Equals(other);
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
        public static bool operator ==(CreateAudioTranscriptionsRequestResponseFormat left, CreateAudioTranscriptionsRequestResponseFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateAudioTranscriptionsRequestResponseFormat left, CreateAudioTranscriptionsRequestResponseFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAudioTranscriptionsRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioTranscriptionsRequestResponseFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioTranscriptionsRequestResponseFormat? ToEnum(string value)
        {
            return CreateAudioTranscriptionsRequestResponseFormat.FromValue(value);
        }
    }
}