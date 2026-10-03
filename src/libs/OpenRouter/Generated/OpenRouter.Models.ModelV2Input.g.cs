
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ModelV2Input : global::System.IEquatable<ModelV2Input>
    {
        /// <summary>
        ///
        /// </summary>
        public ModelV2Input(string value)
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
        public static ModelV2Input Audio { get; } = new("audio");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Input File { get; } = new("file");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Input Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Input Text { get; } = new("text");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Input Video { get; } = new("video");
        /// <summary>
        ///
        /// </summary>
        public static ModelV2Input FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audio" => Audio,
                "file" => File,
                "image" => Image,
                "text" => Text,
                "video" => Video,
                _ => new ModelV2Input(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audio" => true,
            "file" => true,
            "image" => true,
            "text" => true,
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
        public bool Equals(ModelV2Input other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelV2Input other && Equals(other);
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
        public static bool operator ==(ModelV2Input left, ModelV2Input right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelV2Input left, ModelV2Input right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelV2InputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelV2Input value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelV2Input? ToEnum(string value)
        {
            return ModelV2Input.FromValue(value);
        }
    }
}