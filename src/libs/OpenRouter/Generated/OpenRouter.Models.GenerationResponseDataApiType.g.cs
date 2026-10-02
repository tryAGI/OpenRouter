
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Type of API used for the generation
    /// </summary>
    public readonly partial struct GenerationResponseDataApiType : global::System.IEquatable<GenerationResponseDataApiType>
    {
        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataApiType(string value)
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
        public static GenerationResponseDataApiType Completions { get; } = new("completions");

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataApiType Decisions { get; } = new("decisions");

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataApiType Embeddings { get; } = new("embeddings");

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataApiType Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataApiType Rerank { get; } = new("rerank");

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataApiType Stt { get; } = new("stt");

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataApiType Tts { get; } = new("tts");

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataApiType Video { get; } = new("video");
        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataApiType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completions" => Completions,
                "decisions" => Decisions,
                "embeddings" => Embeddings,
                "image" => Image,
                "rerank" => Rerank,
                "stt" => Stt,
                "tts" => Tts,
                "video" => Video,
                _ => new GenerationResponseDataApiType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "completions" => true,
            "decisions" => true,
            "embeddings" => true,
            "image" => true,
            "rerank" => true,
            "stt" => true,
            "tts" => true,
            "video" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GenerationResponseDataApiType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerationResponseDataApiType other && Equals(other);
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
        public static bool operator ==(GenerationResponseDataApiType left, GenerationResponseDataApiType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GenerationResponseDataApiType left, GenerationResponseDataApiType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataApiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataApiType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataApiType? ToEnum(string value)
        {
            return GenerationResponseDataApiType.FromValue(value);
        }
    }
}