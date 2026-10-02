
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The generation phase this chunk belongs to. `content` is the renderable output; `reasoning` and `draft` are intermediate provider phases.
    /// </summary>
    public readonly partial struct ImageGenTextChunkEventPhase : global::System.IEquatable<ImageGenTextChunkEventPhase>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenTextChunkEventPhase(string value)
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
        public static ImageGenTextChunkEventPhase Content { get; } = new("content");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenTextChunkEventPhase Draft { get; } = new("draft");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenTextChunkEventPhase Reasoning { get; } = new("reasoning");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenTextChunkEventPhase FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "content" => Content,
                "draft" => Draft,
                "reasoning" => Reasoning,
                _ => new ImageGenTextChunkEventPhase(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "content" => true,
            "draft" => true,
            "reasoning" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageGenTextChunkEventPhase other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenTextChunkEventPhase other && Equals(other);
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
        public static bool operator ==(ImageGenTextChunkEventPhase left, ImageGenTextChunkEventPhase right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenTextChunkEventPhase left, ImageGenTextChunkEventPhase right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenTextChunkEventPhaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenTextChunkEventPhase value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenTextChunkEventPhase? ToEnum(string value)
        {
            return ImageGenTextChunkEventPhase.FromValue(value);
        }
    }
}