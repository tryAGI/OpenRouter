
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ModelV2Output : global::System.IEquatable<ModelV2Output>
    {
        /// <summary>
        ///
        /// </summary>
        public ModelV2Output(string value)
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
        public static ModelV2Output Audio { get; } = new("audio");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Output Decisions { get; } = new("decisions");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Output Embeddings { get; } = new("embeddings");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Output Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Output Rerank { get; } = new("rerank");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Output Speech { get; } = new("speech");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Output Text { get; } = new("text");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Output Transcription { get; } = new("transcription");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Output Video { get; } = new("video");
        /// <summary>
        ///
        /// </summary>
        public static ModelV2Output FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audio" => Audio,
                "decisions" => Decisions,
                "embeddings" => Embeddings,
                "image" => Image,
                "rerank" => Rerank,
                "speech" => Speech,
                "text" => Text,
                "transcription" => Transcription,
                "video" => Video,
                _ => new ModelV2Output(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audio" => true,
            "decisions" => true,
            "embeddings" => true,
            "image" => true,
            "rerank" => true,
            "speech" => true,
            "text" => true,
            "transcription" => true,
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
        public bool Equals(ModelV2Output other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelV2Output other && Equals(other);
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
        public static bool operator ==(ModelV2Output left, ModelV2Output right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelV2Output left, ModelV2Output right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelV2OutputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelV2Output value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelV2Output? ToEnum(string value)
        {
            return ModelV2Output.FromValue(value);
        }
    }
}